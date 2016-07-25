using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using RecipesProject.Views;

namespace RecipesProject.Controllers
{
	public class ItemController
	{
		private static RecipesContext _context = new RecipesContext();

		public static User Owner { get; set; }

		internal static void AddItem()
		{
			string name;
			Console.Write("Item name: ");
			name = Console.ReadLine();

			_context.Items.Add(new Item()
			{
				Name = name,
				Owner_Id = UserController.foundUser.Id
			});
			_context.SaveChanges();
			Messages.Show("Item added");
		}

		internal static void Remove()
		{
			string name;
			Console.Write("Item to remove: ");
			name = Console.ReadLine();

			var item = _context.Items.FirstOrDefault(i => (i.Name == name && i.Owner_Id == Owner.Id));
			if (item == null)
				Messages.Show("Item is not in the fridge");
			else
			{
				_context.Items.Remove(item);
				_context.SaveChanges();
				Messages.Show("Item removed");
			}
		}

		internal static void ViewAll()
		{
			IEnumerable<string> items = _context.Items
				.Where(i => i.Owner_Id == Owner.Id)
				.Select(i => i.Name);
			foreach (var item in items)
			{
				Messages.Show("\t", item);
			}
		}
	}
}
