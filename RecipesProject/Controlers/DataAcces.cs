using System;
using System.Collections.Generic;
using RecipesProject.Models;

namespace RecipesProject.Controlers
{
	public class DataAcces : IDisposable
	{
		RecipesProjectContext context;
		public void Add<T>(T parameter) where T : class
		{	
				context.Set<T>().Add(parameter);
				Dispose();
		}

		public void  Remove<T>(T parameter) where T : class
		{
			context.Set<T>().Remove(parameter);
			Dispose();
		}

		public T Get<T>(int idparam ) where T : class
		{
				var item = context.Set<T>().Find(idparam);
				return (T)item;
				Dispose();
		}

		public List<T> GetAll<T>() where T : class
		{
				var TheList = new List<T>();
				foreach (T elem in context.Set<T>())
				{
					TheList.Add(elem);
				}
				return TheList;
				Dispose();
		}

		public void  Dispose()
		{
			this.context.SaveChanges();
		}

		public DataAcces()
		{
			context = new RecipesProjectContext();
		}
	}
}
