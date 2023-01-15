using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ArnaudWeil2022.Models
{
    public class ShopFactory : DbContext // Adgang til data
    {
        public DbSet<Product> Products { get; set; } // Repræsentere vores tables 

        public ShopFactory()
        {
            Database.SetInitializer(new ShopInitializer());
        }
    }
}