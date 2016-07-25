using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject.Views
{
	public class MenuView
	{
		internal static int ShowMenu(List<string> menuList)
		{
			for (int i = 0; i < menuList.Count; i++)
				Console.WriteLine("{0}. {1}", i + 1, menuList[i]);

			int output = -1;
			if (!int.TryParse(Console.ReadLine(), out output) || (output < 1 || output > menuList.Count))
				output = ShowMenu(menuList);

			return output;
		}
	}
}
