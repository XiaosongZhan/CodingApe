namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change5 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Financial Analysis', 'Investing', 'Forex', 'Stock Trading', 'Financial Modeling', 'Financial Fundamentals', 'Excel', 'Accounting', 'Python', 10)");
        }
        
        public override void Down()
        {
        }
    }
}
