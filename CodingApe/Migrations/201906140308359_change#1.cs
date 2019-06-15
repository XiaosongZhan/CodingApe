namespace CodingApe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsBuyClass = c.Boolean(nullable: false),
                        CategoriesID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoriesID, cascadeDelete: true)
                .Index(t => t.CategoriesID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoriesName = c.String(),
                        SectionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .Index(t => t.SectionID);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                        TopicsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Topics", t => t.TopicsID, cascadeDelete: true)
                .Index(t => t.TopicsID);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TopicsName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "CategoriesID", "dbo.Categories");
            DropForeignKey("dbo.Categories", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.Sections", "TopicsID", "dbo.Topics");
            DropIndex("dbo.Sections", new[] { "TopicsID" });
            DropIndex("dbo.Categories", new[] { "SectionID" });
            DropIndex("dbo.Classes", new[] { "CategoriesID" });
            DropTable("dbo.Topics");
            DropTable("dbo.Sections");
            DropTable("dbo.Categories");
            DropTable("dbo.Classes");
        }
    }
}
