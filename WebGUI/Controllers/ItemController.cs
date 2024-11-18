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
        /// <summary>
        /// Gets the default view for the item controller
        /// </summary>
        /// <returns>The index of all active items</returns>
        [HttpGet]
        public ActionResult Index()
        {
            var items = new BLL.BLL.ItemBLL().GetAllItems();
            return View("Index", items);
        }
        /// <summary>
        /// Returns the partial view for updating an items details.
        /// This view is used inside the index view to update an item.
        /// </summary>
        /// <param name="id">The ID of the relevant item</param>
        /// <returns></returns>
        public ActionResult UpdateItem(int id)
        {
            var item = new BLL.BLL.ItemBLL().GetItem(id);
            ViewBag.action = "UpdateItem";
            return PartialView("_UpdateItem", item);
        }
        /// <summary>
        /// POST endpoint for updating an item in the DB
        /// Redirects to the index view after the update
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateItem(Item item)
        {
            var bll = new BLL.BLL.ItemBLL();
            bll.UpdateItem(item);
            return RedirectToAction("Index");
        }
        /// <summary>
        /// POST endpoint for adding an item to the DB
        /// Redirects to the index view after the add
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddItem(Item item)
        {
            var bll = new BLL.BLL.ItemBLL();
            bll.AddItem(item);
            return RedirectToAction("Index");
        }
        /// <summary>
        /// Returns the partial view for adding a new item to the DB
        /// This view is used inside the index view.
        /// </summary>
        /// <param name="id">Must not be an allready exsisting ID. Use -1</param>
        /// <returns></returns>
        public ActionResult AddItem(int id)
        {
            var item = new Item();
            ViewBag.action = "AddItem";
            return PartialView("_UpdateItem", item);
        }
    }
}