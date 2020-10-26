using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kitapçı3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kitapçı3.Controllers
{
    public class ÜyeController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult YeniÜye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniÜye(Üye ü)
        {
            c.üyes.Add(ü);
            c.SaveChanges();
            return RedirectToAction("YeniÜye");
        }
        public IActionResult Üyeler()
        {
            var degerler = c.üyes.ToList();
            return View(degerler);
        }
    }
}
