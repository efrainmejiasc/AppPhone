namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class virtualCO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VirtualCourse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCourse = c.Int(nullable: false),
                        IdUser = c.Int(nullable: false),
                        IdComunity = c.Int(nullable: false),
                        IdCompany = c.Int(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        Publish = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Contact = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VirtualCourse");
        }
    }
}
