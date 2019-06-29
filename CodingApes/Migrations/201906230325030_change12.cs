namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change12 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Investment Banking', 'Personal Finance', 'CFA', 'Financial Management', 'Finance Fundamentals', 'Financial Analysis', 'Company Valuation', 'Excel', 'Quantitative Financial', 29)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('CFA', 'Financial Markets', 'ACCA', 'Quantitative Finance', 'CMA', 'Stock Trading', 'Company Valuation', 'Fixed Income Securities', 'Financial Management', 30)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Financial Analysis', 'Financial Modeling', 'Finance Fundamentals', 'Excel', 'Investing', 'Investing Banking', 'Python', 'Accounting', 'CFA', 31)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Stock Trading', 'Investing', 'Forex', 'Financial Analysis', 'Technical Analysis', 'Options Trading', 'Financial Trading', 'Day Trading', 'Algorithmic Trading', 32)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Excel', 'QuickBooks Online', 'QuickBooks', 'QuickBooks Pro', 'SAP FICO', 'Financial Modeling', 'Xero', 'Financial Analysis', 'Excel Analytics', 33)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Tax Preparation', 'Goods and Services Tax', 'Personal Finance', 'Accounting', 'Finance Fundamentals', 'QuickBooks Online', 'Financial Planning', 'Law', 'Value Added Tax(VAT)', 34)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('PowerPoint', 'Passive Income', 'Online Business', 'AdSense', 'Personal Finance', 'Debt', 'Law of Attraction', 'Personal Transformation', 'Investing', 35)");

        }

        public override void Down()
        {
        }
    }
}
