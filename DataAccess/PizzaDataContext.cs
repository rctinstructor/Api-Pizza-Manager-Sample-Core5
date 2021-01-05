using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApiManager.DataAccess
{
    public class PizzaDataContext : DbContext
    {
            public PizzaDataContext(DbContextOptions<PizzaDataContext> options)
                : base(options)
            { }
            public DbSet<Pizza> Pizzas { get; set; }

            public DbSet<PizzaSize> Sizes { get; set; }

    }
}
