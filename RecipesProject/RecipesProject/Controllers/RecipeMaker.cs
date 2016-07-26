using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class RecipeMaker
  {
    internal static void AddRecipe(Recipe recipe, Product ingredient)
    {
        recipe.Items.Add(ingredient);
    }
  }
}
