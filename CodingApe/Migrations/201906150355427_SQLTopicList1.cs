namespace CodingApe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SQLTopicList1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9) VALUES('Amazon AWS', 'Machine Learning', 'Python', 'AWS Certification', 'Data Science', 'Agile', 'Professional Scrum Master(PSM)', 'Big Data', 'Interviewing Skills')");
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9) VALUES('Docker', 'DevOps', 'Git', 'Jenkins', 'JIRA', 'Kubernetes', 'GitHub', 'Confluence', 'Node.js')");
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8) VALUES('WooCommerce', 'WordPress for Ecommerce', 'Magento', 'Shopify', 'Dropshipping', 'Online Business', 'Membership Website', 'WordPress')");
        }
        
        public override void Down()
        {
        }
    }
}
