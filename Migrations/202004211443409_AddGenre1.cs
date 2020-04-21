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
            AddColumn("dbo.Games", "Genre_Id", c => c.Byte());
            CreateIndex("dbo.Games", "Genre_Id");
            AddForeignKey("dbo.Games", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            DropColumn("dbo.Games", "Genre_Id");
            DropColumn("dbo.Games", "NumInStock");
            DropColumn("dbo.Games", "DateAdded");
            DropColumn("dbo.Games", "ReleaseDate");
            DropTable("dbo.Genres");
        }
    }
}
