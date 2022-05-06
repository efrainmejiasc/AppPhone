namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class progress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnoucingProgress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPatner = c.Int(nullable: false),
                        IdEconomicSector = c.Int(nullable: false),
                        IdProductService = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        PublishDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApplyProgress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAnoucingProgress = c.Int(nullable: false),
                        ApplyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CtrlCommunity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCommunity = c.Int(nullable: false),
                        IdUser = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CtrlCommunity");
            DropTable("dbo.ApplyProgress");
            DropTable("dbo.AnoucingProgress");
        }
    }
}
