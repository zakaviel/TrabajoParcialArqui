using MvcShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShopping.Controllers
{
    public class HomeController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        // GET: Home
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            Session["NumeroItems"] = cart.GetCount();
            return View();
        }
        public ActionResult Temp()
        {
            return View();
        }
    }
}