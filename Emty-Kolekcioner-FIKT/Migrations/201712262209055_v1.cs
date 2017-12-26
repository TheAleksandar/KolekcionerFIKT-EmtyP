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
                        UserID = c.Int(nullable: false, identity: true),
                        IdPhoto = c.Int(nullable: false),
                        PhotoBr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddKolekcions");
        }
    }
}
