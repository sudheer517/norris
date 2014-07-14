namespace norris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_comments_context : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        USER_EMAIL = c.Int(nullable: false),
                        FACT_ID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
