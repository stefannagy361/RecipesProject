using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RecipesProject.Models
{
	public class Fridge
	{
		 [Required]
		public int Id { get; set; }

		 [Required]
		public int UserId { get; set; }

		public List<Ingredient> Ingridients { get; set; }
	}
}
