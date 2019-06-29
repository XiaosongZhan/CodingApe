namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change14 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Excel', 'Excel VBA', 'Excel Formulas and Fundations', 'Data Analysis', 'PowerPoint', 'Pivot Tables', 'Microsoft Access', 'Microsoft Word', 'Microsoft Project', 40)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('iMovie', 'Apple Keynote', 'Mac Basics', 'Numbers For Mac', 'Mac Pages', 'macOS', 'Scrivener', 'iPad Basics', 'Microsoft Word', 41)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Google Sheets', 'Google Drive', 'Excel', 'Google Apps', 'Gmail Productivity', 'G Suite', 'Python', 'Data Analysis', 'Google Docs', 42)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('SAP ABAP', 'SAP MM', 'SAP SD', 'SAP Financial Accounting', 'SAP Basis', 'Supply Chain', 'SAP BusinessOnjects', 'SAP HCM', 43)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('SQL', 'Oracle Database', 'Oracle SQL', 'PI/SQL', 'Database Adminstration', 'Oracle Business Intelligence', 'Oracle Data Integrator', 'Porject Planning', 'Oracle Fusion HCM', 44)");

        }

        public override void Down()
        {
        }
    }
}
