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
    public List<Product> Items { get; set; }
  }
}
