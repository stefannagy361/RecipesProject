using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
	public class Recipe
	{
		public string Name { get; set; }
		public List<string> Ingredients { get; set; }
	}
}
