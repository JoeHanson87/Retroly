namespace Retroly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "NumInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Games", "GenreId", c => c.Byte());
            CreateIndex("dbo.Games", "GenreId");
            AddForeignKey("dbo.Games", "GenreId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GenreId", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "GenreId" });
            DropColumn("dbo.Games", "GenreId");
            DropColumn("dbo.Games", "NumInStock");
            DropColumn("dbo.Games", "DateAdded");
            DropColumn("dbo.Games", "ReleaseDate");
            DropTable("dbo.Genres");
        }
    }
}
