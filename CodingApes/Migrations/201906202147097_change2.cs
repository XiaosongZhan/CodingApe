namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('JavaScript', 'Angular', 'React', 'CSS', 'PHP', 'Node.Js', 'Vue,js', 'WordPress', 1)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Android Development', 'IOS Development', 'Swift', 'Google Flutter', 'React Native', 'Ionic', 'Kotlin', 'Mobile Development', 'Java', 2)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('Python', 'C#', 'C++', 'React', 'Spring Framework', 'Node.js', 'Data Analysis', 'Object Oriented Programming', 3)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Unity', 'Game Development Fundamentals', 'C#', 'Unreal Engine', '3D Game Development', 'C++', '2D Game Development', 'Unreal Engine Blueprints', 'Mobile Game Development', 4)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('SQL', 'MySQL', 'MongoDB', 'Oracle SQL', 'SQL Server', 'Apache Kafka', 'Oracle Certification', 'Database Management', 'Oracle Database', 5)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('Selenium WebDriver', 'Java', 'Selenium Testing Framework', 'Python', 'Automation Testing', 'API Testing', 'Automation', 'Appium', 6)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Amazon AWS', 'Machine Learning', 'Python', 'AWS Certification', 'Data Science', 'Agile', 'Professional Scrum Master(PSM)', 'Big Data', 'Interviewing Skills', 7)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Docker', 'DevOps', 'Git', 'Jenkins', 'JIRA', 'Kubernetes', 'GitHub', 'Confluence', 'Node.js', 8)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('WooCommerce', 'WordPress for Ecommerce', 'Magento', 'Shopify', 'Dropshipping', 'Online Business', 'Membership Website', 'WordPress', 9)");
        }
        
        public override void Down()
        {
        }
    }
}
