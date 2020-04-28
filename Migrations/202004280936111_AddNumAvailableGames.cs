namespace Retroly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumAvailableGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "NumAvailable", c => c.Int(nullable: false));

            Sql("UPDATE Games SET NumAvailable = NumInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "NumAvailable");
        }
    }
}
