namespace SearchWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SearchResultViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SearchEngineName = c.String(),
                        Subject = c.String(),
                        Url = c.String(),
                        Text = c.String(),
                        Published = c.DateTime(nullable: false),
                        RawDara = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SearchResultViewModels");
        }
    }
}
