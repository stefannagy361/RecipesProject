using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class Fridge
  {
    public int ID { get; set; }
    public int User_ID { get; set; } //FK
    
    public List<Product> Products { get; set; }
  }
}
