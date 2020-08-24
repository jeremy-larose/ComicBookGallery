using System;
using System.Web.Mvc;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if( DateTime.Today.DayOfWeek == DayOfWeek.Monday )
            {
                return Redirect("/");
            }

            return Content("Hello from the Comic books controller!");
        }
    }
}