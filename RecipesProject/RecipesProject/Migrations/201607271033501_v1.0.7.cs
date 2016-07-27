namespace RecipesProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v107 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RecipeProducts", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.RecipeProducts", "Product_ID", "dbo.Products");
            DropIndex("dbo.RecipeProducts", new[] { "Recipe_Id" });
            DropIndex("dbo.RecipeProducts", new[] { "Product_ID" });
            AddColumn("dbo.Recipes", "Items", c => c.String());
            AddColumn("dbo.Recipes", "Product_ID", c => c.Int());
            CreateIndex("dbo.Recipes", "Product_ID");
            AddForeignKey("dbo.Recipes", "Product_ID", "dbo.Products", "ID");
            DropTable("dbo.RecipeProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RecipeProducts",
                c => new
                    {
                        Recipe_Id = c.Int(nullable: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Recipe_Id, t.Product_ID });
            
            DropForeignKey("dbo.Recipes", "Product_ID", "dbo.Products");
            DropIndex("dbo.Recipes", new[] { "Product_ID" });
            DropColumn("dbo.Recipes", "Product_ID");
            DropColumn("dbo.Recipes", "Items");
            CreateIndex("dbo.RecipeProducts", "Product_ID");
            CreateIndex("dbo.RecipeProducts", "Recipe_Id");
            AddForeignKey("dbo.RecipeProducts", "Product_ID", "dbo.Products", "ID", cascadeDelete: true);
            AddForeignKey("dbo.RecipeProducts", "Recipe_Id", "dbo.Recipes", "Id", cascadeDelete: true);
        }
    }
}
