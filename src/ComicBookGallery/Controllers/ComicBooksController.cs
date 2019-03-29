using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        //RedirectResult and Content Result have the same base class of ActionResult (see F12, hover over keyword.)
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");

            }

            return Content("Hello from the comic book controller.");

           
        }
    }
}