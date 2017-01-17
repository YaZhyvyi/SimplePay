namespace DatabaseLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
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
                .PrimaryKey(t => t.ID);
            
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
                        Phone = c.String(),
                        Address = c.String(maxLength: 50),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        ToSomeone = c.String(maxLength: 40),
                        Summa = c.Double(nullable: false),
                        Comment = c.String(maxLength: 255),
                        CurrencyForDate_ID = c.Int(nullable: false),
                        FromUser_ID = c.Int(nullable: false),
                        ToUser_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CurrencyForDates", t => t.CurrencyForDate_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.FromUser_ID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ToUser_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.CurrencyForDate_ID)
                .Index(t => t.FromUser_ID)
                .Index(t => t.ToUser_ID)
                .Index(t => t.User_ID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "ToUser_ID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "FromUser_ID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "CurrencyForDate_ID", "dbo.CurrencyForDates");
            DropForeignKey("dbo.CurrencyForDates", "Currency_ID", "dbo.Currencies");
            DropForeignKey("dbo.Accounts", "Currency_ID", "dbo.Currencies");
            DropIndex("dbo.CurrencyForDates", new[] { "Currency_ID" });
            DropIndex("dbo.Transactions", new[] { "User_ID" });
            DropIndex("dbo.Transactions", new[] { "ToUser_ID" });
            DropIndex("dbo.Transactions", new[] { "FromUser_ID" });
            DropIndex("dbo.Transactions", new[] { "CurrencyForDate_ID" });
            DropIndex("dbo.Accounts", new[] { "User_ID" });
            DropIndex("dbo.Accounts", new[] { "Currency_ID" });
            DropTable("dbo.CurrencyForDates");
            DropTable("dbo.Transactions");
            DropTable("dbo.Users");
            DropTable("dbo.Currencies");
            DropTable("dbo.Accounts");
        }
    }
}
