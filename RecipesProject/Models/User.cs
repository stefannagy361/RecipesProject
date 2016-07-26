using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipesProject.Models
{
	public class User
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public int  Password { get; set; }
	}
}
