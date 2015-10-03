using PagedList;
using PagedListApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PagedListApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {
            int itemsPerPage = 25;
            int pageNumber = page ?? 1;
            List<Lucky> luckyGuids = new List<Lucky>();
            for (int i = 0; i < 100; i++)
            {
                luckyGuids.Add(new Lucky() { Guid = Guid.NewGuid().ToString() });
            }
            return View(luckyGuids.ToPagedList(pageNumber, itemsPerPage));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}