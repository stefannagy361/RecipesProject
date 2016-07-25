using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesProject.Models;
using System.Data.Entity;

namespace RecipesProject
{
	public class DataAcces
	{
		public static void Add<T>(T parameter, DbContext context,  DbSet set)
		{
			
			set.Add(parameter);	
			context.SaveChanges();
		}

		public static void  Remove<T>(T parameter, DbContext context, DbSet set)
		{
			set.Remove(parameter);
			context.SaveChanges();
		}
		public static T Get<T>(int idparam, DbContext context, DbSet set )
		{
			var item = set.Find(idparam);
			return (T)item;
		}
		public static List<T> GetAll<T>(DbContext context, DbSet set )
		{	
			var TheList = new List<T>();
			foreach( T elem in set)			
			TheList.Add(elem);
			
			return TheList;
		}
	}
}
