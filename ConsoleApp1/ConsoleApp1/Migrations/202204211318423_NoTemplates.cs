namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoTemplates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TemplateNewsTrendsFiveDetail", "TemplateNewsTrendsFiveId", "dbo.TemplateNewsTrendsFive");
            DropForeignKey("dbo.TemplateNewsTrendsSixDetail", "TemplateNewsTrendsSixId", "dbo.TemplateNewsTrendsSix");
            DropForeignKey("dbo.TemplateNewsTrendsThreeDetail", "TemplateNewsTrendsThreeId", "dbo.TemplateNewsTrendsThree");
            DropIndex("dbo.TemplateNewsTrendsFiveDetail", new[] { "TemplateNewsTrendsFiveId" });
            DropIndex("dbo.TemplateNewsTrendsSixDetail", new[] { "TemplateNewsTrendsSixId" });
            DropIndex("dbo.TemplateNewsTrendsThreeDetail", new[] { "TemplateNewsTrendsThreeId" });
            DropTable("dbo.TemplateNewsTrendsFive");
            DropTable("dbo.TemplateNewsTrendsFiveDetail");
            DropTable("dbo.TemplateNewsTrendsFour");
            DropTable("dbo.TemplateNewsTrendsOne");
            DropTable("dbo.TemplateNewsTrendsSix");
            DropTable("dbo.TemplateNewsTrendsSixDetail");
            DropTable("dbo.TemplateNewsTrendsThree");
            DropTable("dbo.TemplateNewsTrendsThreeDetail");
            DropTable("dbo.TemplateNewsTrendsTwo");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TemplateNewsTrendsTwo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 40, unicode: false),
                        TextRef = c.String(nullable: false, maxLength: 100, unicode: false),
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
                        Link = c.String(nullable: false, maxLength: 100, unicode: false),
                        RolloVer = c.String(maxLength: 100, unicode: false),
                        Status = c.Boolean(nullable: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        TemplateNewsTrendsThreeId = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateNewsTrendsSix",
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
                "dbo.TemplateNewsTrendsOne",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 40, unicode: false),
                        TextArea = c.String(nullable: false, maxLength: 500, unicode: false),
                        LinkText = c.String(maxLength: 20, unicode: false),
                        Link = c.String(maxLength: 100, unicode: false),
                        RolloVer = c.String(maxLength: 100, unicode: false),
                        Status = c.Boolean(nullable: false),
                        Section = c.Int(nullable: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateNewsTrendsFour",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextArea = c.String(nullable: false, maxLength: 40, unicode: false),
                        LinkText = c.String(maxLength: 20, unicode: false),
                        Link = c.String(maxLength: 100, unicode: false),
                        RolloVer = c.String(maxLength: 100, unicode: false),
                        Status = c.Boolean(nullable: false),
                        Section = c.Int(nullable: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateNewsTrendsFiveDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextRef = c.String(nullable: false, maxLength: 100, unicode: false),
                        Link = c.String(nullable: false, maxLength: 100, unicode: false),
                        Status = c.Boolean(nullable: false),
                        IdUserCreate = c.Int(nullable: false),
                        IdUserUpdate = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        TemplateNewsTrendsFiveId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateNewsTrendsFive",
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
            
            CreateIndex("dbo.TemplateNewsTrendsThreeDetail", "TemplateNewsTrendsThreeId");
            CreateIndex("dbo.TemplateNewsTrendsSixDetail", "TemplateNewsTrendsSixId");
            CreateIndex("dbo.TemplateNewsTrendsFiveDetail", "TemplateNewsTrendsFiveId");
            AddForeignKey("dbo.TemplateNewsTrendsThreeDetail", "TemplateNewsTrendsThreeId", "dbo.TemplateNewsTrendsThree", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TemplateNewsTrendsSixDetail", "TemplateNewsTrendsSixId", "dbo.TemplateNewsTrendsSix", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TemplateNewsTrendsFiveDetail", "TemplateNewsTrendsFiveId", "dbo.TemplateNewsTrendsFive", "Id", cascadeDelete: true);
        }
    }
}
