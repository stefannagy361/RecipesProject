using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;

namespace RecipesProject.Controlers
{
	public class UserServices
	{
		public static void AddUser(string _name, string _password)
		{
			using (var _context = new RecipesProjectContext())
			{
				var _user = new User() { Name = _name, Password = _password.GetHashCode() };
				var Acces = new DataAcces();
				Acces.Add<User>(_user);
				var _UserId = FindUserId(_name, _password);
				FridgeService.AddFridge(_UserId);
			};
				
			}
	
		public static void ViewAll()
		{
			using (var _context = new RecipesProjectContext())
			{
				var userslist = new DataAcces().GetAll<User>();
				foreach (var _user in userslist)
					Console.WriteLine(_user.Name);
			}
		}
		public static int FindUserId(string _name, string _pass)
		{
			using (var _context = new RecipesProjectContext())
			{
				int _userid = -1;
				var userslist = new DataAcces().GetAll<User>();
				foreach (var _user in userslist)
				{
					if ((_name == _user.Name) && (_pass.GetHashCode() == _user.Password))
					{
						_userid = _user.Id;
						return _userid;
					}
				}
				return _userid;
			}
		}
	}
}