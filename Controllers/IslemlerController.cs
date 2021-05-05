using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class IslemlerController : Controller
    {
        // GET: Islemler
        SQLProjeEntities db = new SQLProjeEntities();
        
        public ActionResult Index()
        {
            var degerler = db.islemler.ToList();
            return View(degerler);
        }
    }
}