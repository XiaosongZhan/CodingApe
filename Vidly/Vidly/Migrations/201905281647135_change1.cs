namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        MembershipId = c.Int(nullable: false, identity: true),
                        Fee = c.Byte(nullable: false),
                        Discount = c.Byte(nullable: false),
                        Duration = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.MembershipId);
            
            CreateIndex("dbo.Customers", "MemberId");
            AddForeignKey("dbo.Customers", "MemberId", "dbo.Memberships", "MembershipId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberId", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MemberId" });
            DropTable("dbo.Memberships");
        }
    }
}
