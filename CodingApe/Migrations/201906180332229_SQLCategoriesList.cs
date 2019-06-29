namespace CodingApe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SQLCategoriesList : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 1)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 2)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 3)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 4)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 5)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 6)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 7)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 8)");
            Sql("INSERT INTO Categories(CategoriesName, SectionID) VALUES('Development', 9)");
        }
        
        public override void Down()
        {
        }
    }
}
