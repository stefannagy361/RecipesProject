using System;
using System.Collections.Generic;

namespace RecipesProject.Views
{
	class MenuView
	{

		internal static int DisplayMenu(List<string> _choiceList)
		{
			
			for (int i = 0; i < _choiceList.Count; i++)
				Console.WriteLine("  {0}. {1}", i + 1, _choiceList[i]);

			int output = -1;
			if (!int.TryParse(Console.ReadLine(), out output) || (output < 1 || output > _choiceList.Count))
			{
				Console.WriteLine("Invalid choice! Try again please");
				output = DisplayMenu(_choiceList);
			}

			return output;
		}
	}
}
