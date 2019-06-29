namespace CodingApes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sections", "CategoryName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sections", "CategoryName");
        }
    }
}
