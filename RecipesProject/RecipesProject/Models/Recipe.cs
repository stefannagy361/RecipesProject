using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class Recipe
  {
    public int Id { get; set; }
    public string Name { get; set; }
    //public IList<Product> Items { get; set; }
    public string Items { get; set; }
  }
}
