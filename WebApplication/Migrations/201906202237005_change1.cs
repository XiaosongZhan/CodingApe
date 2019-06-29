namespace WebApplication.Migrations
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
                        Id = c.Int(nullable: false, identity: true),
                        MemberName = c.String(),
                        Fee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberId");
            AddForeignKey("dbo.Customers", "MemberId", "dbo.Memberships", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberId", "dbo.Memberships");
            DropIndex("dbo.Customers", new[] { "MemberId" });
            DropColumn("dbo.Customers", "MemberId");
            DropTable("dbo.Memberships");
        }
    }
}
