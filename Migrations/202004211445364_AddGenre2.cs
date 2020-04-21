namespace Retroly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GenreId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "GenreId");
        }
    }
}
