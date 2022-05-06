namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class templates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TemplateFive",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextRef = c.String(nullable: false, maxLength: 100, unicode: false),
                        Link = c.String(maxLength: 8000, unicode: false),
                        NumbersPage = c.Int(nullable: false),
                        IdPartner = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateFour",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextArea = c.String(nullable: false, maxLength: 40, unicode: false),
                        LinkText = c.String(maxLength: 20, unicode: false),
                        Link = c.String(maxLength: 100, unicode: false),
                        RolloVer = c.String(maxLength: 100, unicode: false),
                        IdPartner = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateOne",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 40, unicode: false),
                        TextArea = c.String(nullable: false, maxLength: 500, unicode: false),
                        LinkText = c.String(maxLength: 20, unicode: false),
                        Link = c.String(maxLength: 100, unicode: false),
                        RolloVer = c.String(maxLength: 100, unicode: false),
                        IdPartner = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateSix",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false, maxLength: 357, unicode: false),
                        Link = c.String(maxLength: 8000, unicode: false),
                        NumbersPage = c.Int(nullable: false),
                        IdPartner = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateThree",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextToPage = c.String(nullable: false, maxLength: 40, unicode: false),
                        NumbersPage = c.Int(nullable: false),
                        Link = c.String(maxLength: 8000, unicode: false),
                        RolloVer = c.String(maxLength: 100, unicode: false),
                        IdPartner = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TemplateTwo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 40, unicode: false),
                        TextRef = c.String(nullable: false, maxLength: 100, unicode: false),
                        IdPartner = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TemplateTwo");
            DropTable("dbo.TemplateThree");
            DropTable("dbo.TemplateSix");
            DropTable("dbo.TemplateOne");
            DropTable("dbo.TemplateFour");
            DropTable("dbo.TemplateFive");
        }
    }
}
