using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcShopping.Models;
using MvcShopping.ViewModel;

namespace MvcShopping.Controllers
{
    public class Shared :Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

         
        public PartialViewResult _GenresList()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView("~/Views/Shared/_GenresList.cshtml", genres);
        }

    }
}