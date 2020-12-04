using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hope.Models;
using Hope.BLL;

namespace Hope.Controllers
{
    public class HopeController : Controller
    {
        public ActionResult HopeList()
        {
            return View();
        }
        public ActionResult CreateHope()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateHope(HopeModel model)
        {
            if (ModelState.IsValid)
            {
                //model-> dto
                HopeBLL bll = new HopeBLL();
                //bll.InsertHope(dto);
               return RedirectToAction("HopeList");
            }
           
            return View(model);
        }
    }
}