using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;

namespace RecipesProject.Models
{
	public class Ingredient
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int FridgeId { get; set; }
	}
}
