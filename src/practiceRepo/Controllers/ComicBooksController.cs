using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practiceRepo.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {   
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "Hello from the comic books controller"
            };
        }
    }
}