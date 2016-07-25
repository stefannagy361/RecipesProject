using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject.Views
{
	public class Messages
	{
		internal static void Show(string message)
		{
			Console.WriteLine(message);
			Console.ReadKey();
		}

		internal static void Show(string p1, string p2)
		{
			Console.WriteLine(p1 + p2);
		}
	}
}
