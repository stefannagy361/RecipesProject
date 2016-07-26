using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject.Models
{
	public class Item
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public int Owner_Id { get; set; }
	}
}
