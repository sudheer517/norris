namespace norris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discussionposts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Discussions", "Votes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Discussions", "Votes");
        }
    }
}
