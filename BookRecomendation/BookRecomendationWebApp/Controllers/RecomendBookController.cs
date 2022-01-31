using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BookRecomendationBusinessLayer;
using BookRecomendationDTO;
using BookRecomendationWebApp.Models;
using Newtonsoft.Json;

namespace BookRecomendationWebApp.Controllers
{
    //DO NOT MODIFY THE METHOD NAMES : Adding of parameters / changing the return types of the given methods may be required.
    public class RecomendBookController : Controller
    {
        // GET: RecomendBook
        public ActionResult Index()
        {
            return View();
        }



        public void AddReviews()
        {

        }

        public ActionResult DisplayResultsUsingWebAPI()
        {
            try
            {
                BookRecomendationBL blObj = new BookRecomendationBL();
                List<BookDTO> lstDto = blObj.ShowReviewsForBook();
                List<BookViewModel> modelObj = new List<BookViewModel>();
                foreach (var books in lstDto)
                {
                    BookViewModel model = new BookViewModel();
                    modelObj.BookID=
                }
                return View(modelObj);
            }

            catch (Exception ex)
            {
                return View("Error");
            }
        }

    }
}