using System.ComponentModel.DataAnnotations;

namespace RecipesProject.Models
{
	public class User : BaseModel
	{
		[Required]
		public string Name { get; set; }
		[Required]
		public int  Password { get; set; }
	}
}
