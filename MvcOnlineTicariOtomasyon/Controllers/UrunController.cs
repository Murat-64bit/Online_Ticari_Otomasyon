using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Uruns.Where(x => x.durum == true).ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.kategoriad,
                                               Value = x.id.ToString()
                                           }).ToList();
                                           ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {
            c.Uruns.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var deger = c.Uruns.Find(id);
            deger.durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.kategoriad,
                                               Value = x.id.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
           
            var urundeger = c.Uruns.Find(id);
            return View("UrunGetir", urundeger);
        }
        public ActionResult UrunGuncelle(Urun p)
        {
            var urn = c.Uruns.Find(p.urunid);
            urn.alisfiyat = p.alisfiyat;
            urn.durum = p.durum;
            urn.kategoriid = p.kategoriid;
            urn.marka = p.marka;
            urn.satisfiyat = p.satisfiyat;
            urn.stok = p.stok;
            urn.urunad = p.urunad;
            urn.urungorsel = p.urungorsel;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}