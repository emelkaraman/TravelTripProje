using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar; 

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var b=c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult BlogGetir(int id)
        {
            var b = c.Blogs.Find(id);
            return View("BlogGetir", b);

        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Tarih = b.Tarih;
            blg.BlogImage= b.BlogImage;
            blg.Baslik = b.Baslik;

            c.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorums.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var y = c.Yorums.Find(id);
            c.Yorums.Remove(y);
            c.SaveChanges();

            return RedirectToAction("YorumListesi");

        }

        public ActionResult YorumGetir(int id)
        {
            var y = c.Yorums.Find(id);
            return View("YorumGetir", y);
        }

        public ActionResult YorumGuncelle(Yorum y)
        {
            var yr = c.Yorums.Find(y.ID);
            yr.KullaniciAdi = y.KullaniciAdi;
            yr.Mail = y.Mail;
            yr.Yorums = y.Yorums;

            c.SaveChanges();

            return RedirectToAction("YorumListesi");

        }


    }
}