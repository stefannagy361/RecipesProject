using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
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
