namespace Vidlee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMovieModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
    "dbo.Genres",
    c => new
    {
        Id = c.Int(nullable: false, identity: true),
        GenreType = c.String(),
    })
    .PrimaryKey(t => t.Id);

            CreateIndex("dbo.Movies", "Genre_Id");
            AddForeignKey("dbo.Movies", "Genre_Id", "dbo.Genres", "Id");
        
    }
        
        public override void Down()
        {
        }
    }
}
