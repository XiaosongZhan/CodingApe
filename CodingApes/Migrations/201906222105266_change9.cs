namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change9 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Data Science', 'Machine Learning', 'Python', 'Data Analysis', 'Deep Learning', 'SQL', 'Artificial Intelligence', 'Microsoft Power BI', 'Tableau', 19)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('Amazon FBA', 'Dropshipping', 'Blogging', 'Online Business', 'SEO', 'Affiliate Marketing', 'Passive Income', 'eBay Selling', 20)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('Recruiting', 'Instructional Design', 'Emotional Intelligence', 'Talent Management', 'Conflict Management', 'Interviewing Skills', 'Management Skills', 'Hiring', 21)");
           
        }
        
        public override void Down()
        {
        }
    }
}
