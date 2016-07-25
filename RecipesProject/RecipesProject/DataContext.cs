﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesProject
{
  class DataContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Fridge> Fridges { get; set; }
    public DbSet<Product> Products { get; set; }

  }
}
