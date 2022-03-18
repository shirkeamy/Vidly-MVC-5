namespace Vidly_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateOfBith : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth='1993/10/01' WHERE Id=1");
            Sql("UPDATE Customers SET DateOfBirth='1997/11/07' WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
