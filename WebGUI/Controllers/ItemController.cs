using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO.Models;

namespace WebGUI.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var items = new BLL.BLL.ItemBLL().GetAllItems();
            return View("Index", items);
        }
        
        public ActionResult UpdateItem(int id)
        {
            var item = new BLL.BLL.ItemBLL().GetItem(id);
            return PartialView("_UpdateItem", item);
        }
        [HttpPost]
        public void UpdateItem(Item item)
        {
            var bll = new BLL.BLL.ItemBLL();
            bll.UpdateItem(item);
            // Redirect to Index should show the updated item
            RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult AddItem(Item item)
        {
            string view = "Index";
            var bll = new BLL.BLL.ItemBLL();
            bll.AddItem(item);
            // Redirect to Index should show the new item
            return RedirectToAction("Item", view);
        }
    }
}