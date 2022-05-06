namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class COANOU : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anoucing",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameAnoucing = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Anoucing");
        }
    }
}
