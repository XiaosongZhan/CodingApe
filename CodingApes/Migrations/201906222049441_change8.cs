namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change8 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Robotic Process Automation', 'Six Sigma Green Belt', 'UiPath', 'Supply Chain', 'Six Sigma', 'Six Sigma Yellow Belt', 'Six Sigma Black Belt', 'Quality Management', 'Lean', 16)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('PMP', 'PMBOX', 'Scrum', 'PMI-ACP', 'Agile', 'PRINCE2', 'CAPM', 'Risk Management', 17)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, SectionID) VALUES('GSPR', 'Data Protection', 'Contract Law', 'Law', 'Contract Negotiation', 'Intellectual Property', 'Trademark', 'Patent', 18)");
            
        }
        
        public override void Down()
        {
        }
    }
}
