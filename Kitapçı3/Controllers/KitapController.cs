using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kitapçı3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Kitapçı3.Controllers
{
    public class KitapController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index1()
        {
            var degerler = c.kitaps.ToList();
            return View(degerler);
        }
        public IActionResult Anasayfa()
        {
            var degerler = c.kitaps.ToList();
            return View(degerler);
        }
        public IActionResult KitapGetir(int ID)
        {
            var ktp = c.kitaps.Find(ID);
            return View("KitapGetir",ktp);
        }
        public IActionResult YeniKitapGetir(int ID)
        {
            var ktp = c.YeniKitaps.Find(ID);
            return View("YeniKitapGetir");
            //var ktp = c.YeniKitaps.Find(ID);
            //return View("YeniKitapGetir");
        }
        public IActionResult BilimSayfa()
        {
            var degerler = c.bilims.ToList();
            return View(degerler);
        }
        public IActionResult BilimGetir(int ID)
        {
            var blm = c.bilims.Find(ID);
            return View("BilimGetir", blm);
        }
        public IActionResult FelsefeSayfa()
        {
            var degerler = c.felseves.ToList();
            return View(degerler);
        }
        public IActionResult FelsefeGetir(int ID)
        {
            var fls = c.felseves.Find(ID);
            return View("FelsefeGetir", fls);
        }
        public IActionResult PsikolojiSayfa()
        {
            var degerler = c.psikolojis.ToList();
            return View(degerler);
        }
        public IActionResult PsikolojiGetir(int ID)
        {
            var psk = c.psikolojis.Find(ID);
            return View("PsikolojiGetir", psk);
        }
        public IActionResult RomanSayfa()
        {
            var degerler = c.romen.ToList();
            return View(degerler);
        }
        public IActionResult RomanGetir(int ID)
        {
            var rmn = c.romen.Find(ID);
            return View("RomanGetir", rmn);
        }
        public IActionResult YeniÇıkanKitapSayfa()
        {
            var degerler = c.yeniÇıkanKitaps.ToList();
            return View(degerler);
        }
        public IActionResult YeniÇıkanKitapGetir(int ID)
        {
            var yeni = c.yeniÇıkanKitaps.Find(ID);
            return View("YeniÇıkanKitapGetir", yeni);
        }
       
    }
}
