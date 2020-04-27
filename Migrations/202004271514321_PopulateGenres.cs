namespace Retroly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Platformer')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'FPS')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Strategy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Shooter')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Combat')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Puzzle')");
        }
        
        public override void Down()
        {
        }
    }
}
