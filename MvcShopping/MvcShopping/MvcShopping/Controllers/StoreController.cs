using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShopping.Models;

namespace MvcShopping.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        public PartialViewResult _GenresList()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView("~/Views/Shared/_GenresList.cshtml", genres);
        }

        // GET: Store
        public ActionResult  Index()
        {
            

            return View();
        }
        public ActionResult Browse(string genre)
        {
            //var genreModel = new Genre { Name = genre };
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);
            return View(genreModel);
        }
        public ActionResult Details(int id)
        {
            //var album = new Album { Title = "Album " + id };
            var album = storeDB.Albums.Find(id);
            return View(album);
        }
    }
}