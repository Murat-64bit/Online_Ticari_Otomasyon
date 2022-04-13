using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Siniflar;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Departmen.Where(x=>x.durum==true).ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DepartmanEkle(Departman d)
        {
            c.Departmen.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult DepartmanSil(int id)
        {
            var dep = c.Departmen.Find(id);
            dep.durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmanGetir(int id)
        {
            var dpt = c.Departmen.Find(id);
            return View("DepartmanGetir", dpt);
        }
        public ActionResult DepartmanGuncelle(Departman p)
        {
            var dpt = c.Departmen.Find(p.departmanid);
            dpt.departmanad = p.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personels.Where(x => x.departmanid == id).ToList();
            var dpt = c.Departmen.Where(x => x.departmanid == id).Select(y => y.departmanad).FirstOrDefault();
            ViewBag.d = dpt;
            return View(degerler);
        }
        
        public ActionResult DepartmanPersonelSatis(int id)
        {
            return View();
        }
    }
}