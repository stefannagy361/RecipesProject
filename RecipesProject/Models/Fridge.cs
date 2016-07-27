using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RecipesProject.Models
{
	public class Fridge: BaseModel
	{
		 [Required]
		public int UserId { get; set; }

		public List<Ingredient> Ingridients { get; set; }
	}
}
