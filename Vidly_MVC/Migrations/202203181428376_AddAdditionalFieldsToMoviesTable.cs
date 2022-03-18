namespace Vidly_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdditionalFieldsToMoviesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 300),
                        DateAdded = c.DateTime(nullable: false),
                        ReleasedDate = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
