namespace norris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Votes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Facts", "UpVote", c => c.Int(nullable: false));
            AddColumn("dbo.Facts", "DownVote", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Facts", "DownVote");
            DropColumn("dbo.Facts", "UpVote");
        }
    }
}
