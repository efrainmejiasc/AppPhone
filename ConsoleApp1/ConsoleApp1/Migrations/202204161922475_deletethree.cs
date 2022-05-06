namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletethree : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TemplateNewsTrendsThree", "TemplateNewsTrendsThreeDetailId", "dbo.TemplateNewsTrendsThreeDetail");
            DropIndex("dbo.TemplateNewsTrendsThree", new[] { "TemplateNewsTrendsThreeDetailId" });
            DropTable("dbo.TemplateNewsTrendsThree");
            DropTable("dbo.TemplateNewsTrendsThreeDetail");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.TemplateNewsTrendsThree", "TemplateNewsTrendsThreeDetailId");
            AddForeignKey("dbo.TemplateNewsTrendsThree", "TemplateNewsTrendsThreeDetailId", "dbo.TemplateNewsTrendsThreeDetail", "Id", cascadeDelete: true);
        }
    }
}
