namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change3 : DbMigration
    {
        public override void Up()
        {
            
            Sql("INSERT INTO Memberships (Fee, Discount, Duration, TypeName) VALUES (0, 0, 0, 'Pay AS You Go')");
            Sql("INSERT INTO Memberships (Fee, Discount, Duration, TypeName) VALUES (20, 10, 1, 'Monthly')");
            Sql("INSERT INTO Memberships (Fee, Discount, Duration, TypeName) VALUES (30, 20, 3, 'Quertly')");
            Sql("INSERT INTO Memberships (Fee, Discount, Duration, TypeName) VALUES (40, 30, 12, 'Annual')");
        }
        
        public override void Down()
        {
        }
    }
}
