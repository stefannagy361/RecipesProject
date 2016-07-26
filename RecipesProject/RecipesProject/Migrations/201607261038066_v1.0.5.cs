namespace RecipesProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v105 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "Instructions", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Recipes", "Instructions");
        }
    }
}
