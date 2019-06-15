namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memberships", "TypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Memberships", "TypeName");
        }
    }
}
