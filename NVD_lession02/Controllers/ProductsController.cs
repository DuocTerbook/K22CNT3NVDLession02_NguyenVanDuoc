using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVD_lession02.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:port/products
        public ActionResult Index()
        {
            ViewBag.name = "Duoc Nguyen - 2210900016";
            return View();
        }
        public ActionResult Details(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public string GetName()
        {
            return "Nguyễn Văn Được - 2210900016";
        }
        public JsonResult ListName()
        {
            string[] name = { "Linh", "Lan", "Hùng", "Dũng" };
            return Json(name, JsonRequestBehavior.AllowGet);
        }
    }
}