using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
	public class RecipesContext : DbContext
	{
		public DbSet<Item> Items { get; set; }
		public DbSet<User> Users { get; set; }

		public RecipesContext()
			: base("RecipesContext")
		{

		}
	}
}
