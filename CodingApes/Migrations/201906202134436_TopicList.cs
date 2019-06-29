namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TopicList : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Topics", "SectionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Topics", "SectionID");
            AddForeignKey("dbo.Topics", "SectionID", "dbo.Sections", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Topics", "SectionID", "dbo.Sections");
            DropIndex("dbo.Topics", new[] { "SectionID" });
            DropColumn("dbo.Topics", "SectionID");
            DropTable("dbo.Sections");
        }
    }
}
