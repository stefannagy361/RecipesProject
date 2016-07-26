namespace RecipesProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v104 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fridges", "User_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Fridges", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Fridges", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Fridges", "User_ID");
        }
    }
}
