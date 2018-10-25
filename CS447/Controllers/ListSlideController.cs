using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CS447.Models;

namespace CS447.Controllers
{
    public class ListSlideController : Controller
    {
        DbBatDongSanEntities db = new DbBatDongSanEntities();
        // GET: ListSlide
        public ActionResult ListSlide()
        {
            return PartialView(db.Slides.Where(x=>x.Status==true).ToList());
        }
    }
}