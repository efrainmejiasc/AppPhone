namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class detailSix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TemplateNewsTrendsSixDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, maxLength: 357, unicode: false),
                        Link = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.Boolean(nullable: false),
                        Section = c.Int(nullable: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        TemplateNewsTrendsSixId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TemplateNewsTrendsSix", t => t.TemplateNewsTrendsSixId, cascadeDelete: true)
                .Index(t => t.TemplateNewsTrendsSixId);
            
            AlterColumn("dbo.TemplateNewsTrendsFiveDetail", "Link", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.TemplateNewsTrendsThreeDetail", "Link", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropColumn("dbo.TemplateNewsTrendsSix", "Text");
            DropColumn("dbo.TemplateNewsTrendsSix", "Link");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TemplateNewsTrendsSix", "Link", c => c.String(maxLength: 8000, unicode: false));
            AddColumn("dbo.TemplateNewsTrendsSix", "Text", c => c.String(nullable: false, maxLength: 357, unicode: false));
            DropForeignKey("dbo.TemplateNewsTrendsSixDetail", "TemplateNewsTrendsSixId", "dbo.TemplateNewsTrendsSix");
            DropIndex("dbo.TemplateNewsTrendsSixDetail", new[] { "TemplateNewsTrendsSixId" });
            AlterColumn("dbo.TemplateNewsTrendsThreeDetail", "Link", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.TemplateNewsTrendsFiveDetail", "Link", c => c.String(maxLength: 8000, unicode: false));
            DropTable("dbo.TemplateNewsTrendsSixDetail");
        }
    }
}
