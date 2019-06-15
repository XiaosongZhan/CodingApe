namespace CodingApe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "TopicsName2", c => c.String());
            AddColumn("dbo.Topics", "TopicsName3", c => c.String());
            AddColumn("dbo.Topics", "TopicsName4", c => c.String());
            AddColumn("dbo.Topics", "TopicsName5", c => c.String());
            AddColumn("dbo.Topics", "TopicsName6", c => c.String());
            AddColumn("dbo.Topics", "TopicsName7", c => c.String());
            AddColumn("dbo.Topics", "TopicsName8", c => c.String());
            AddColumn("dbo.Topics", "TopicsName9", c => c.String());
            AddColumn("dbo.Topics", "TopicsName10", c => c.String());
            AddColumn("dbo.Topics", "TopicsName11", c => c.String());
            AddColumn("dbo.Topics", "TopicsName12", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Topics", "TopicsName12");
            DropColumn("dbo.Topics", "TopicsName11");
            DropColumn("dbo.Topics", "TopicsName10");
            DropColumn("dbo.Topics", "TopicsName9");
            DropColumn("dbo.Topics", "TopicsName8");
            DropColumn("dbo.Topics", "TopicsName7");
            DropColumn("dbo.Topics", "TopicsName6");
            DropColumn("dbo.Topics", "TopicsName5");
            DropColumn("dbo.Topics", "TopicsName4");
            DropColumn("dbo.Topics", "TopicsName3");
            DropColumn("dbo.Topics", "TopicsName2");
        }
    }
}
