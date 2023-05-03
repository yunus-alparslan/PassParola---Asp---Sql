using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pspasp.Models.Enty;

namespace pspasp.Controllers
{
    public class DefaultController : Controller
    {

        PspPrlEntities psp = new PspPrlEntities();

        public ActionResult Index()
        {
            var psd = psp.Table_Soru.ToList();
          //  psd.


            return View(psd);
        }
    }
}