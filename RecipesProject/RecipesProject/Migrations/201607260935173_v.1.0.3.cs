namespace RecipesProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v103 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ingredients", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Recipes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Recipes", "Ingredients", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Recipes", "Ingredients", c => c.String());
            AlterColumn("dbo.Recipes", "Name", c => c.String());
            AlterColumn("dbo.Ingredients", "Name", c => c.String());
        }
    }
}
