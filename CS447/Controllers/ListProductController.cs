using CS447.Models;
using System.Linq;
using System.Web.Mvc;
using PagedList;

namespace CS447.Controllers
{
    public class ListProductController : Controller
    {
        private DbBatDongSanEntities db = new DbBatDongSanEntities();
        // GET: ListProduct
        public ActionResult ListNameProduct(int? page)
        {
            int pageSize = 8;
            int pageNumber = (page ?? 1);
            var model = db.Products.Where(x => x.Status == true && x.ShowOnHome == true).OrderBy(i=>i.Name).ToPagedList<Product>(pageNumber, pageSize);
            return PartialView(model);
        }
    }
}