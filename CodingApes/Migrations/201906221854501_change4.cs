namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change4 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sections(CategoryName) VALUES('Development')");
        }
        
        public override void Down()
        {
        }
    }
}
