namespace norris.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Facts",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Text = c.String(),
                    Author = c.String(),
                    Date = c.DateTime(nullable: false),
                    Views = c.Int()
                })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.Facts");
        }
    }
}
