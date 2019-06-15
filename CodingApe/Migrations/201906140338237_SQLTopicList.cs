namespace CodingApe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SQLTopicList : DbMigration
    {
        public override void Up()
        {
            
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8) VALUES('JavaScript', 'Angular', 'React', 'CSS', 'PHP', 'Node.Js', 'Vue,js', 'WordPress')");
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9) VALUES('Android Development', 'IOS Development', 'Swift', 'Google Flutter', 'React Native', 'Ionic', 'Kotlin', 'Mobile Development', 'Java')");
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8) VALUES('Python', 'C#', 'C++', 'React', 'Spring Framework', 'Node.js', 'Data Analysis', 'Object Oriented Programming')");
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9) VALUES('Unity', 'Game Development Fundamentals', 'C#', 'Unreal Engine', '3D Game Development', 'C++', '2D Game Development', 'Unreal Engine Blueprints', 'Mobile Game Development')");
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9) VALUES('SQL', 'MySQL', 'MongoDB', 'Oracle SQL', 'SQL Server', 'Apache Kafka', 'Oracle Certification', 'Database Management', 'Oracle Database')");
            Sql("INSERT INTO Topics(TopicsName, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8) VALUES('Selenium WebDriver', 'Java', 'Selenium Testing Framework', 'Python', 'Automation Testing', 'API Testing', 'Automation', 'Appium')");
        }
        public override void Down()
        {
        }
    }
}
