namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class claveThreeTest : DbMigration
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
                        TemplateNewsTrendsThreeDetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TemplateNewsTrendsThreeDetail", t => t.TemplateNewsTrendsThreeDetailId, cascadeDelete: true)
                .Index(t => t.TemplateNewsTrendsThreeDetailId);
            
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TemplateNewsTrendsThree", "TemplateNewsTrendsThreeDetailId", "dbo.TemplateNewsTrendsThreeDetail");
            DropIndex("dbo.TemplateNewsTrendsThree", new[] { "TemplateNewsTrendsThreeDetailId" });
            DropTable("dbo.TemplateNewsTrendsThreeDetail");
            DropTable("dbo.TemplateNewsTrendsThree");
        }
    }
}
