using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class Product
  {
    public int ID { get; set; }
    public string Name { get; set; }

    public int FridgeId { get; set; } //FK
    public virtual Fridge Fridge { get;set; }

    //public IList<Recipe> Recipes { get; set; }

  }
}
