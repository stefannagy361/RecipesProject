using System.Data.Entity;

namespace RecipesProject.Models
{
public	class RecipesProjectContext : DbContext
	{
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Fridge> Fridges { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Recipe> Recipes { get; set; }

		public RecipesProjectContext() : base()
		{

		}
	}
}
