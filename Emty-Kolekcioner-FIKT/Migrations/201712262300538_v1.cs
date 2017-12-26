namespace Emty_Kolekcioner_FIKT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddKolekcions",
                c => new
                    {
                        IDphoto = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        PhotoBr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDphoto);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAccounts");
            DropTable("dbo.AddKolekcions");
        }
    }
}
