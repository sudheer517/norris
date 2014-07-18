namespace norris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class discussionsamecontext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Discussions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Author = c.String(),
                        Date = c.DateTime(nullable: false),
                        Views = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Discussions");
        }
    }
}
