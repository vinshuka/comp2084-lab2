using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            List<String> products = new List<String>{ "Laptop", "Tablet", "Desktop" };
            ViewData.Add("Products", products);
            return View();
        }

        public ActionResult Details(string product)
        {
            ViewBag.Message = "You selected product: " + product;
            return View();
        }
    }
}