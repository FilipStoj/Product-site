using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Web.Helpers;
using ArnaudWeil2022.Models;
using ArnaudWeil2022.ViewModels.Home;


namespace ArnaudWeil2022.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchCriteria)
        {
            var factory = new ShopFactory(); // Instance af DB
            IQueryable<Product> prods = factory.Products.OrderBy(p => p.Name); // Query i alfabetisk rækkefølge
            if (searchCriteria != null) 
            {
                prods = prods.Where(p => p.Name.Contains(searchCriteria));
            }
            var products = prods.Take(10).ToList(); // Returnere 10
            return View(products);
        }


        // FirstOfDefault returnere enkelt record fra databasen based on Where condition. 
        public ActionResult Details(int id)
        {
            var factory = new ShopFactory();
            var found = factory.Products.Where(p => p.ID == id).FirstOrDefault();
            return View(found); 
        }

        public ActionResult Picture(int id)
        {
            var factory = new ShopFactory();
            var product = factory.Products.Where(p => p.ID == id).FirstOrDefault();

            if (product == null)
            {
                return HttpNotFound();
            }

            var img = new WebImage(string.Format("~/Content/Images/{0}.jpg", product.ImageName));
            img.Resize(50, 50);
            return File(img.GetBytes(), "image/jpg");
        }

        public ActionResult ComputeProduct(decimal? number1, decimal? number2)
        {
            var viewModel = new ComputeProductViewModel(number1, number2);
            return View(viewModel);
        }
    }
}