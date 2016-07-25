using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;

namespace RecipesProject.Models
{
	public class Recipe
	{
		//public int Id { get; set; };
		public string Name { get; set; }
		public List<String> Ingredients {get;set;}
	}
}
