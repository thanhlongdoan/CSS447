using CS447.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS447.Controllers
{
    public class ListCategoryController : Controller
    {
        private DbBatDongSanEntities db = new DbBatDongSanEntities();
        // GET: ListCategory
        public ActionResult ListNameCategory()
        {
            var model = db.Categories.Where(x => x.Status == true).ToList();
            return PartialView(model);
        }
    }
}