namespace DatabaseLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Accounts", "PersonalNumber", unique: true);
            CreateIndex("dbo.Currencies", "ShortName", unique: true);
            CreateIndex("dbo.Currencies", "FullName", unique: true);
            CreateIndex("dbo.Users", "Login", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
            CreateIndex("dbo.Users", "Phone", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Phone" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Login" });
            DropIndex("dbo.Currencies", new[] { "FullName" });
            DropIndex("dbo.Currencies", new[] { "ShortName" });
            DropIndex("dbo.Accounts", new[] { "PersonalNumber" });
        }
    }
}
