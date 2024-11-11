using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGUI.Controllers
{
    public class SaleController : Controller
    {

        private List<DTO.Models.Item> getItems()
        {
            //Dummy data
            var itemModels = new List<DTO.Models.Item>();
            itemModels.Add(new DTO.Models.Item(1, "Bajer", 10.00, "/Content/Images/CarlsbergPilsner.jpg"));
            itemModels.Add(new DTO.Models.Item(2, "Bræz", 20.00, "/Content/Images/Alkohol.jpg"));

            return itemModels;
        }

        // GET: Sale
        public ActionResult SaleHomepage()
        {
            //fetch items and populate page
            //var itemModels = BLL.BLL.ItemBLL.GetItems();
            //ViewBag.items = itemModels;

            return View("SaleHomepage", getItems());
        }

     
        public ActionResult AddItemToOrder(int itemId)
        {
            var order = Session["Order"] as DTO.Models.Order;

            if (order == null)
            {
                var orderLines = new List<DTO.Models.OrderLine>();
                order = new DTO.Models.Order(1);
                order.OrderLines = orderLines;
                Session["Order"] = order;
            }
            
            var item = getItems().Find(x => x.ID == itemId);

            //find ud af, om der allerede er en ordrelinje med varen
            var foundOrderline = order.OrderLines.Find(x => x.Item.ID == item.ID);

            if (foundOrderline != null)
            {
                foundOrderline.Quantity++;
            }
            else 
            {
                var orderLine = new DTO.Models.OrderLine(1, 1, item);
                order.OrderLines.Add(orderLine);
            }

            ViewBag.order = order;

            return View("SaleHomepage", getItems());
        }

      
        public ActionResult RegisterSale()
        {
            //for each orderline in order: DB.Item =- Orderline.item.count in DB

            return View("SaleHomepage", null);
        }
    }
}