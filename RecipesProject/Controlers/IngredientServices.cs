using RecipesProject.Models;

namespace RecipesProject.Controlers
{
	public class IngredientServices
	{
		public static void AddItem(int  _userid,string _ingridientname)
		{
				new DataAcces().Add<Ingredient>(
					new Ingredient() 
					{	
						Name = _ingridientname,
						FridgeId = FridgeService.FindId(_userid) 
					});
		}

		public static void removeItem(int _userid, string _ingridientname)
		{	
				//new	DataAcces().Remove<Ingredient>(, _context, _context.Fridges);
			
		}
	}
}
