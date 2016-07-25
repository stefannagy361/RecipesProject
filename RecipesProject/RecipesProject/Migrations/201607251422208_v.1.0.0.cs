namespace RecipesProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v100 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fridges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Fridge_ID = c.Int(nullable: false),
                        Fridge_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Fridges", t => t.Fridge_ID1)
                .Index(t => t.Fridge_ID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Fridge_ID1", "dbo.Fridges");
            DropIndex("dbo.Products", new[] { "Fridge_ID1" });
            DropTable("dbo.Products");
            DropTable("dbo.Fridges");
        }
    }
}
