namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FiveDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TemplateNewsTrendsFiveDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextRef = c.String(nullable: false, maxLength: 100, unicode: false),
                        Link = c.String(maxLength: 8000, unicode: false),
                        Status = c.Boolean(nullable: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        TemplateNewsTrendsFiveId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TemplateNewsTrendsFive", t => t.TemplateNewsTrendsFiveId, cascadeDelete: true)
                .Index(t => t.TemplateNewsTrendsFiveId);
            
            AddColumn("dbo.TemplateNewsTrendsThreeDetail", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.TemplateNewsTrendsFive", "TextRef");
            DropColumn("dbo.TemplateNewsTrendsFive", "Link");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TemplateNewsTrendsFive", "Link", c => c.String(maxLength: 8000, unicode: false));
            AddColumn("dbo.TemplateNewsTrendsFive", "TextRef", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropForeignKey("dbo.TemplateNewsTrendsFiveDetail", "TemplateNewsTrendsFiveId", "dbo.TemplateNewsTrendsFive");
            DropIndex("dbo.TemplateNewsTrendsFiveDetail", new[] { "TemplateNewsTrendsFiveId" });
            DropColumn("dbo.TemplateNewsTrendsThreeDetail", "Status");
            DropTable("dbo.TemplateNewsTrendsFiveDetail");
        }
    }
}
