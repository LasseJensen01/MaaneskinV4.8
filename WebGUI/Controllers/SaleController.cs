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
            //var itemModels = BLL.BLL.ItemBLL.GetItems();
            //ViewBag.items = itemModels;

            //Dummy data
            var itemModels = new List<DTO.Models.Item>();
            itemModels.Add(new DTO.Models.Item(1, "Bajer", 10.00, "/Content/Images/CarlsbergPilsner.jpg"));
            itemModels.Add(new DTO.Models.Item(2, "Bræz", 20.00, "/Content/Images/Alkohol.jpg"));

            return View("SaleHomepage", itemModels);
        }

        [HttpPost]
        public ActionResult RegisterSale()
        {
            //for each orderline in order: DB.Item =- Orderline.item.count in DB

            return View("SaleHomepage", null);
        }
    }
}