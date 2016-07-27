using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
