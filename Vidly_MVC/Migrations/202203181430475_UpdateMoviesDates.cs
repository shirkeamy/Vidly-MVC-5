namespace Vidly_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesDates : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies (Name,DateAdded,ReleasedDate,NumberInStock) VALUES ('The Kashmir Files','2022/03/18','2022/03/11',10)");
            Sql("Insert into Movies (Name,DateAdded,ReleasedDate,NumberInStock) VALUES ('Love Mocktail 2','2022/03/16','2022/02/11',5)");
        }
        
        public override void Down()
        {
        }
    }
}
