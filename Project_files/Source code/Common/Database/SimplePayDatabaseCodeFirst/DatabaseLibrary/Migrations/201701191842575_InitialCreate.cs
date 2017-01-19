namespace DatabaseLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonalNumber = c.String(nullable: false, maxLength: 12),
                        Balance = c.Double(nullable: false),
                        Currency_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Currencies", t => t.Currency_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.PersonalNumber, unique: true)
                .Index(t => t.Currency_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortName = c.String(nullable: false, maxLength: 3),
                        FullName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.ShortName, unique: true)
                .Index(t => t.FullName, unique: true);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TransactionType = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        Summa = c.Double(nullable: false),
                        Comment = c.String(maxLength: 1000),
                        CurrencyForDate_ID = c.Int(nullable: false),
                        FromUserAccount_ID = c.Int(nullable: false),
                        ToUserAccount_ID = c.Int(),
                        Account_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CurrencyForDates", t => t.CurrencyForDate_ID, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.FromUserAccount_ID, cascadeDelete: true)
                .ForeignKey("dbo.Accounts", t => t.ToUserAccount_ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID)
                .Index(t => t.CurrencyForDate_ID)
                .Index(t => t.FromUserAccount_ID)
                .Index(t => t.ToUserAccount_ID)
                .Index(t => t.Account_ID);
            
            CreateTable(
                "dbo.CurrencyForDates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Multiplier = c.Double(nullable: false),
                        Currency_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Currencies", t => t.Currency_ID, cascadeDelete: true)
                .Index(t => t.Currency_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsAdmin = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 40),
                        Surname = c.String(nullable: false, maxLength: 40),
                        Login = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 14),
                        Email = c.String(maxLength: 50),
                        Phone = c.String(nullable: false),
                        Address = c.String(maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Login, unique: true)
                .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "ToUserAccount_ID", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "FromUserAccount_ID", "dbo.Accounts");
            DropForeignKey("dbo.Transactions", "CurrencyForDate_ID", "dbo.CurrencyForDates");
            DropForeignKey("dbo.CurrencyForDates", "Currency_ID", "dbo.Currencies");
            DropForeignKey("dbo.Accounts", "Currency_ID", "dbo.Currencies");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Login" });
            DropIndex("dbo.CurrencyForDates", new[] { "Currency_ID" });
            DropIndex("dbo.Transactions", new[] { "Account_ID" });
            DropIndex("dbo.Transactions", new[] { "ToUserAccount_ID" });
            DropIndex("dbo.Transactions", new[] { "FromUserAccount_ID" });
            DropIndex("dbo.Transactions", new[] { "CurrencyForDate_ID" });
            DropIndex("dbo.Currencies", new[] { "FullName" });
            DropIndex("dbo.Currencies", new[] { "ShortName" });
            DropIndex("dbo.Accounts", new[] { "User_ID" });
            DropIndex("dbo.Accounts", new[] { "Currency_ID" });
            DropIndex("dbo.Accounts", new[] { "PersonalNumber" });
            DropTable("dbo.Users");
            DropTable("dbo.CurrencyForDates");
            DropTable("dbo.Transactions");
            DropTable("dbo.Currencies");
            DropTable("dbo.Accounts");
        }
    }
}
