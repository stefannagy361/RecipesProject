namespace RecipesProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v108 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Recipes", "Product_ID", "dbo.Products");
            DropIndex("dbo.Recipes", new[] { "Product_ID" });
            DropColumn("dbo.Recipes", "Product_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recipes", "Product_ID", c => c.Int());
            CreateIndex("dbo.Recipes", "Product_ID");
            AddForeignKey("dbo.Recipes", "Product_ID", "dbo.Products", "ID");
        }
    }
}
