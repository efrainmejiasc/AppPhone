namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameUser = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AnoucingProgress", "IdUser", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateFive", "IdUser", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateFour", "IdUser", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateOne", "IdUser", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateSix", "IdUser", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateThree", "IdUser", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateTwo", "IdUser", c => c.Int(nullable: false));
            DropColumn("dbo.AnoucingProgress", "IdPatner");
            DropColumn("dbo.TemplateFive", "IdPartner");
            DropColumn("dbo.TemplateFour", "IdPartner");
            DropColumn("dbo.TemplateOne", "IdPartner");
            DropColumn("dbo.TemplateSix", "IdPartner");
            DropColumn("dbo.TemplateThree", "IdPartner");
            DropColumn("dbo.TemplateTwo", "IdPartner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TemplateTwo", "IdPartner", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateThree", "IdPartner", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateSix", "IdPartner", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateOne", "IdPartner", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateFour", "IdPartner", c => c.Int(nullable: false));
            AddColumn("dbo.TemplateFive", "IdPartner", c => c.Int(nullable: false));
            AddColumn("dbo.AnoucingProgress", "IdPatner", c => c.Int(nullable: false));
            DropColumn("dbo.TemplateTwo", "IdUser");
            DropColumn("dbo.TemplateThree", "IdUser");
            DropColumn("dbo.TemplateSix", "IdUser");
            DropColumn("dbo.TemplateOne", "IdUser");
            DropColumn("dbo.TemplateFour", "IdUser");
            DropColumn("dbo.TemplateFive", "IdUser");
            DropColumn("dbo.AnoucingProgress", "IdUser");
            DropTable("dbo.Users");
        }
    }
}
