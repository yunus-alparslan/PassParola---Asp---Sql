using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pspasp.Models.Enty;

namespace pspasp.Controllers
{
    public class SORUEKLEController : Controller
    {

        PspPrlEntities soruis = new PspPrlEntities();
        // GET: SORUEKLE
        public ActionResult Index()
        {
            return View();
        }

          [HttpGet]
        public ActionResult soruekle()
        {
            return View();
        }



        [HttpPost]
        public ActionResult soruekle(Table_Soru sr){

            soruis.Table_Soru.Add(sr);

            soruis.SaveChanges();


            return View(sr);
        }
    }
}