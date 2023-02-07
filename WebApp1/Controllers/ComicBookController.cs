using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        public ActionResult Index()
        {
            ViewBag.SeriesTitle = "Comic Book Index";
            ViewBag.IssueNumber = 550;
            ViewBag.Description = "<p>Descrition area ..........</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Bam",
                "Pen: Red Hurnl",
                "Socs: Mices",
                "Colors: Edgar Delgado S"
            };

            return View();
        }
    }
}