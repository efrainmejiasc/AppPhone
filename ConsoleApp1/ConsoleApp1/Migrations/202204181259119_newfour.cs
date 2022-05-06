namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newfour : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TemplateNewsTrendsFour");
        }
    }
}
