using System.ComponentModel.DataAnnotations;

namespace RecipesProject.Models
{
	public class Recipe : BaseModel
	{
		
		[Required]
		public string Name { get; set; }

		[Required]
		public string Ingredients {get;set;}

		[Required]
		public string Instructions { get; set; }

		[Required]
		public int PublisherId {get; set;}
	}
}
