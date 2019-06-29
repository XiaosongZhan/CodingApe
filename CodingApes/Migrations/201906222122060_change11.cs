namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change11 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Accounting', 'Finance Fundamental', 'Financial Accounting', 'Bookkeeping', 'SAP FICO', 'Startup', 'Xero', 'Financial Markets', 'Cost Accounting', 25)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('Risk Management', 'Anti-Money Laundering', 'Accounting', 'Finance Fundamentals', 'IFRS', 'ACCA', 'Internal Auditing', 'Financial Risk Manager(FRM)', 26)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Crytocurrency', 'Bitcoin', 'Blockchain', 'Bitcoin Trading', 'Crytography', 'Ethereum', 'Forex', 'Algorithmic Trading', 'Stock Trading', 27)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('Microeconomics', 'Macroeconomics', 'College Admissions', 'Math', 'Entrepreneurship Fundamentals', 'Politial Science', 'CFA', 'Personal Finance', 28)");
            
        }

        public override void Down()
        {
        }
    }
}
