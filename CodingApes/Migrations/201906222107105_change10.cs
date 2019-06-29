namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change10 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Life Coaching', 'Electrical Engineering', 'Manufacturing', 'Pharmacy', 'Oli and Gas Industry', 'Construction', 'Management Skills', 'Piping', 'Management Consulting', 22)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Podcasting', 'After Effects', 'Motion Graphics', 'Screenwriting', 'Amazon Kindle', 'Scrivener', 'Environment Lighting', 'Journalism', 'Audiobook Creation', 23)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('Real Estate Investing', 'Construction', 'Airbnb Hosting', 'Financial Modeling', 'Real Estate Leads', 'Real Estate Flipping', 'Risk Management', 'House Buying', 24)");
        }
        
        public override void Down()
        {
        }
    }
}
