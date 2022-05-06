namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsName : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TemplateNewsTrendsFive",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextRef = c.String(nullable: false, maxLength: 100, unicode: false),
                        Link = c.String(maxLength: 8000, unicode: false),
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
                "dbo.TemplateNewTrendsFour",
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
                "dbo.TemplateNewsTrendsSix",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, maxLength: 357, unicode: false),
                        Link = c.String(maxLength: 8000, unicode: false),
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
                "dbo.TemplateNewsTrendsThree",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextToPage = c.String(nullable: false, maxLength: 40, unicode: false),
                        NumbersPage = c.Int(nullable: false),
                        Link = c.String(maxLength: 8000, unicode: false),
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TemplateNewsTrendsTwo");
            DropTable("dbo.TemplateNewsTrendsThree");
            DropTable("dbo.TemplateNewsTrendsSix");
            DropTable("dbo.TemplateNewsTrendsOne");
            DropTable("dbo.TemplateNewTrendsFour");
            DropTable("dbo.TemplateNewsTrendsFive");
        }
    }
}
