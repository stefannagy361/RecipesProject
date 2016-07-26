using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;

namespace RecipesProject.Controlers
{
	public class AutentificatorService
	{
		public static int _Session = 0;

		public static void LogOut()
		{
			_Session = 0;
		}

		public static bool CheckforUser(string _username)
		{
			bool _output = false;
			using (var _context = new RecipesProjectContext())
			{
				var userslist = DataAcces.GetAll<User>(_context, _context.Users);
				foreach (var _user in userslist)
				{
					if (_username == _user.Name)
					{
						_output=true;
						break;
					}
				}
				return _output;
			}
		}
	}
}
