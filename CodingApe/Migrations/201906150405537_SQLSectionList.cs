namespace CodingApe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SQLSectionList : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Web Development', 1)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Mobile Apps', 2)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Programming Languages', 3)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Game Development', 4)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Databases', 5)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Software Testing', 6)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Software Engineering', 7)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('Development Tools', 8)");
            Sql("INSERT INTO Sections(SectionName, TopicsID) VALUES('E-Commerce', 9)");
        }
        
        public override void Down()
        {
        }
    }
}
