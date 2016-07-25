using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
	public class Fridge
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public List<Ingredient> Ingridients { get; set; }
	}
}
