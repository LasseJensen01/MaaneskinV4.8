using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGUI.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        public ActionResult SaleHomepage()
        {
            //fetch items and populate page
            var itemModels = BLL.BLL.ItemBLL.GetItems();
            ViewBag.items = itemModels;

            return View();
        }

        [HttpPost]
        public ActionResult RegisterSale()
        {
            //for each orderline in order: DB.Item =- Orderline.item.count in DB

            return View("SaleHomepage", null);
        }
    }
}