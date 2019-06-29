namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sections(SectionName) VALUES('Web Development')");
            Sql("INSERT INTO Sections(SectionName) VALUES('Mobile Apps')");
            Sql("INSERT INTO Sections(SectionName) VALUES('Programming Languages')");
            Sql("INSERT INTO Sections(SectionName) VALUES('Game Development')");
            Sql("INSERT INTO Sections(SectionName) VALUES('Databases')");
            Sql("INSERT INTO Sections(SectionName) VALUES('Software Testing')");
            Sql("INSERT INTO Sections(SectionName) VALUES('Software Engineering')");
            Sql("INSERT INTO Sections(SectionName) VALUES('Development Tools')");
            Sql("INSERT INTO Sections(SectionName) VALUES('E-Commerce')");
        }
        
        public override void Down()
        {
        }
    }
}
