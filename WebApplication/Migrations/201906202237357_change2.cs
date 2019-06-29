namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Memberships(MemberName, Fee) VALUES('Annual', 100)");
            Sql("INSERT INTO Memberships(MemberName, Fee) VALUES('Single', 10)");
        }
        
        public override void Down()
        {
        }
    }
}
