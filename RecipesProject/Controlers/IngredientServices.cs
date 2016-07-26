using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using System.Data.Entity;

namespace RecipesProject.Controlers
{
	public class IngredientServices
	{
		public static void AddItem(int  _userid,string _ingridientname)
		{
			using (var _context = new RecipesProjectContext())
			{
				DataAcces.Add<Ingredient>(new Ingredient() { Name = _ingridientname, FridgeId = FridgeService.FindId(_userid) }, _context, _context.Ingredients);
			}
		}

		public static void removeItem(int _userid, string _ingridientname)
		{
			using (var _context = new RecipesProjectContext())
			{	
				//DataAcces.Remove<Ingredient>(, _context, _context.Fridges);
			}
		}
	}
}
