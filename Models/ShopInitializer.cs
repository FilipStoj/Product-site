using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ArnaudWeil2022.Models
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        //protected override void Seed(ShopFactory context)
        //{
        //    context.Products.Add(new Product() { Name = "Yoghurt", Description = "This creamy one will melt you", Price = 5.4M, ImageName = "yoghurt" });
        //    context.Products.Add(new Product() { Name = "Cleaning lotion", Description = "Nothing gets in its way", Price = 64M, ImageName = "spray" });
        //    context.Products.Add(new Product() { Name = "Banana", Description = "Hungry ? That's going to get you satisfied", Price = 3M, ImageName = "banana" });
        //    context.Products.Add(new Product() { Name = "Goat Cheese", Description = "Goat cheese is made in a wide variety of styles, from soft fresh cheese to hard aged cheese.", Price = 10M, ImageName = "goatcheese" });
        //}
    }
}