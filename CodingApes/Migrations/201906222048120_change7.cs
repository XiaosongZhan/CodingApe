namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change7 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Product Management', 'Leadership', 'Management Skills', 'Agile', 'PMP', 'Scrum', 'Risk Mangement', 'Business Process Management', 'ISO 9001', 13)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Sales Skills', 'B2B Sales', 'LinkedIn', 'Lead Generation', 'Business Development', 'Cold Emial', 'Sales Funnel', 'Presentation Skills', 'Dropshipping', 14)");
            Sql("INSERT INTO Topics(TopicsName1, TopicsName2, TopicsName3, TopicsName4, TopicsName5, TopicsName6, TopicsName7, TopicsName8, TopicsName9, SectionID) VALUES('Digital Marketing', 'Business Strategy', 'Busniess Model', 'Forex', 'Management Consulting', 'Excel', 'Financial Modeling', 'Innovation', 'Financial Trading', 15)");
            
        }
        
        public override void Down()
        {
        }
    }
}
