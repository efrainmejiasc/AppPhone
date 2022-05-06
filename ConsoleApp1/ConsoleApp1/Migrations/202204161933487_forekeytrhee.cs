namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forekeytrhee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TemplateNewsTrendsThree",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumbersPage = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Section = c.Int(nullable: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateNewsTrendsThreeDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextToPage = c.String(nullable: false, maxLength: 40, unicode: false),
                        Link = c.String(maxLength: 8000, unicode: false),
                        RolloVer = c.String(maxLength: 100, unicode: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        TemplateNewsTrendsThreeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TemplateNewsTrendsThree", t => t.TemplateNewsTrendsThreeId, cascadeDelete: true)
                .Index(t => t.TemplateNewsTrendsThreeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TemplateNewsTrendsThreeDetail", "TemplateNewsTrendsThreeId", "dbo.TemplateNewsTrendsThree");
            DropIndex("dbo.TemplateNewsTrendsThreeDetail", new[] { "TemplateNewsTrendsThreeId" });
            DropTable("dbo.TemplateNewsTrendsThreeDetail");
            DropTable("dbo.TemplateNewsTrendsThree");
        }
    }
}
