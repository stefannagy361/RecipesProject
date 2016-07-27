using System.ComponentModel.DataAnnotations;

namespace RecipesProject.Models
{
	public class Ingredient : BaseModel
	{	
		
		[Required]
		public string Name { get; set; }

		[Required]
		public int FridgeId { get; set; }
	}
}
