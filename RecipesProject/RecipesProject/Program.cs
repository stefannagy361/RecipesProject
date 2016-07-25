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
      var menu = new MenuOptions();
     switch(MainMenu.Menu(menu))
     {
       case 1:
         RegisterMenu.Register();
         break;
       case 2:
         LoginMenu.Login();
         break;
       case 3:

         break;
       default:

         break;
     }
		}
	}
}
