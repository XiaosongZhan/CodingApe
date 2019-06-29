namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change6 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Business Fundamentals', 'Dropshipping', 'Amazon FBA', 'Entrepreneurship Fundamentals', 'Busniess Strategy', 'Business Plan', 'Freelancing', 'Startup', 'Mug Printing', 11)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Writing', 'Public Speaking', 'Communication Skills', 'Presentation Skills', 'Fiction Writing', 'Marketing Strategy', 'Writing Editing', 'Storytelling', 'Novel Writing', 12)");
        }

        public override void Down()
        {
        }
    }
}
