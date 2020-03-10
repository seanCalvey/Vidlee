namespace Vidlee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedMemberrshipTypesNames1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' Where DiscountRate = 0");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' Where DiscountRate = 10");
            Sql("UPDATE MembershipTypes SET Name = 'Quartly' Where DiscountRate = 15");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' Where DiscountRate = 20");
        }
        
        public override void Down()
        {
        }
    }
}
