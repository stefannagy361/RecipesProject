using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using System.Data.Entity;

namespace RecipesProject
{
	public class FridgeService
	{
		public static void AddFridge(int  _userid)
		{
			using (var _context = new RecipesProjectContext())
			{
				
				DataAcces.Add<Fridge>(new Fridge(){UserId = _userid},_context,_context.Fridges);
			}
		}

		public static List<Ingredient> OpenFridge(int  _userid)
		{
			using (var _context = new RecipesProjectContext())
			{
				
				var _ingList=DataAcces.GetAll<Ingredient>(_context,_context.Ingredients);
				int _fridgeId = FindId(_userid);
				   var query = (from i in _ingList
								where i.FridgeId == _fridgeId
                             select i).ToList();
				   return query;
			}
		}
			
		public static int FindId(int _userid)
		{
			using (var _context = new RecipesProjectContext())
			{
				int _fridgeid = -1;
				var fridgelist = DataAcces.GetAll<Fridge>(_context, _context.Fridges);
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
}
