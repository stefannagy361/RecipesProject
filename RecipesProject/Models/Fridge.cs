using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecipesProject.Models
{
	public class Fridge: BaseModel
	{
		 [Required]
		public int UserId { get; set; }

		public List<Ingredient> Ingridients { get; set; }
	}
}
