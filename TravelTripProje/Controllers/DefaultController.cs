using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Context c = new Context();
        public ActionResult Index()
        {
            //Anasayfa yüklenirken 4 blog resmi gösterilecek
            var degerler= c.Blogs.Take(4).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {

            return View();
        }

        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        public PartialViewResult Partial2()
        {
            //Anasayfa yüklenirken 10 blog gösterilecek
            var degerler = c.Blogs.Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
    }
}