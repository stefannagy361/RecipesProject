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
				DataAcces.Add<User>(_user, _context, _context.Users);
				var _UserId = FindUserId(_name, _password);
				FridgeService.AddFridge(_UserId);
			};
				
			}
	
		public static void ViewAll()
		{
			using (var _context = new RecipesProjectContext())
			{
				var userslist = DataAcces.GetAll<User>(_context, _context.Users);
				foreach (var _user in userslist)
					Console.WriteLine(_user.Name);
			}
		}
		public static int FindUserId(string _name, string _pass)
		{
			using (var _context = new RecipesProjectContext())
			{
				int _userid = -1;
				var userslist = DataAcces.GetAll<User>(_context, _context.Users);
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