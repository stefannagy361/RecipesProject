using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
	class Program
	{
		static void Main(string[] args)
		{
      int o=-1;
      var menu = new MenuOptions();
      do{
         switch(MainMenu.Menu(menu))
         {
           case 1:
             RegisterMenu.Register();
             break;
           case 2:
             LoginMenu.Login();
             break;
           case 3:
             FridgeMaker.AddFridge();
             break;
           case 4:
             ProductMenu.AddProduct();
             break;
           case 5:
             ProductMenu.RemoveProduct();
             break;
           case 6:
             ItemShow.ShowItems();
             break;
           case 7:
             RecipeMenu.ShowRecipeMenu();
             break;
           case 0:

             break;
           default:

             break;
         }
      }while(o!=0);
		}
	}
}
