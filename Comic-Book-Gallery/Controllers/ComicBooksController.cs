using System;
using System.Web.Mvc;
using Comic_Book_Gallery.Data;
using Comic_Book_Gallery.Models;

namespace Comic_Book_Gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRespository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRespository();
        }
        
        public ActionResult Detail( int? id )
        {
            if (id == null)
            {
                return new HttpNotFoundResult();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value);
            return View( comicBook );
        }
    }
}