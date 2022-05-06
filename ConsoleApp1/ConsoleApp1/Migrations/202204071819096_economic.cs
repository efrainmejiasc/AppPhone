namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class economic : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Community",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCommunity = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameCompany = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyEconomicSector",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCompany = c.Int(nullable: false),
                        IdEconomicSector = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EconomicSector",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameEconomicSector = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductService",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameProductService = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductService");
            DropTable("dbo.EconomicSector");
            DropTable("dbo.CompanyEconomicSector");
            DropTable("dbo.Company");
            DropTable("dbo.Community");
        }
    }
}
