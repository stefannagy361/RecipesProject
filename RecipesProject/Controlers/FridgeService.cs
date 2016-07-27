using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using System.Data.Entity;

namespace RecipesProject.Controlers
{
	public class FridgeService
	{
		public static void AddFridge(int  _userid)
		{
				new DataAcces().Add<Fridge>(new Fridge(){UserId = _userid});
		}

		public static List<Ingredient> OpenFridge(int  _userid)
		{

			var _ingList = new DataAcces().GetAll<Ingredient>();
				int _fridgeId = FindId(_userid);
					var query = (from i in _ingList
								where i.FridgeId == _fridgeId
                             select i).ToList();
				   return query;
		}
			
		public static int FindId(int _userid)
		{
				int _fridgeid = -1;
				var fridgelist = new DataAcces().GetAll<Fridge>().ToList<Fridge>();
				foreach (var _fridge in fridgelist)
				{
					if (_userid == _fridge.UserId)
					{
						_fridgeid = _fridge.Id;
						return _fridge.Id;
					}
				}
				return _userid;
		}
	}
}
