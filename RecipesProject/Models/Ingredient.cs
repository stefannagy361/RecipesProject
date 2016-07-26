using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using System.ComponentModel.DataAnnotations;

namespace RecipesProject.Models
{
	public class Ingredient
	{	
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		[Required]
		public int FridgeId { get; set; }
	}
}
