namespace norris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_comments_context1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "USER_EMAIL", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "USER_EMAIL", c => c.Int(nullable: false));
        }
    }
}
