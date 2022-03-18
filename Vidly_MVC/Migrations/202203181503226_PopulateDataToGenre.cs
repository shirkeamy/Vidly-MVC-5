namespace Vidly_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDataToGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) Values('Comedy')");
            Sql("INSERT INTO Genres(Name) Values('Romance/Drama')");
            Sql("INSERT INTO Genres(Name) Values('Action')");
            Sql("INSERT INTO Genres(Name) Values('Adventure')");
            Sql("INSERT INTO Genres(Name) Values('Crime and mystery')");

        }

        public override void Down()
        {
        }
    }
}
