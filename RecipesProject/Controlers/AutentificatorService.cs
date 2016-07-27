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
			var userslist = new DataAcces().GetAll<User>();
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
