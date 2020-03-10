namespace Vidlee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDateOfBirthToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth = 24/04/1986 Where Name = 'Mary Williams'");
        }
        
        public override void Down()
        {
        }
    }
}
