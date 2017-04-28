namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingGenreGenreNametoGenreName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Genres", "GenreName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "GenreName", c => c.String(nullable: false, maxLength: 75));
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 25));
            DropColumn("dbo.Genres", "Name");
        }
    }
}
