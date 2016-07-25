using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  static class Session
  {
    static public int Session_ID { get; set; }

    internal static void SetSession(int id)
    {
      Session_ID = id;
      Notifications.LoginSuccessful();
    }
  }
}
