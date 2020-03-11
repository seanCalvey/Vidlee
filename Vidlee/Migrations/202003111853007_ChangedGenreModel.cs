namespace Vidlee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedGenreModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Name", c => c.String());
            DropColumn("dbo.Genres", "GenreType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "GenreType", c => c.String());
            DropColumn("dbo.Genres", "Name");
        }
    }
}
