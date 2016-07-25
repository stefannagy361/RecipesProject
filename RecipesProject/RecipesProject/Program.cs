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
           case 0:

             break;
           default:

             break;
         }
      }while(o!=0);
		}
	}
}
