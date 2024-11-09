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
        public ActionResult Index()
        {
            //Dummy items for debugging
            var dummy = new List<Item>
            {
                new Item(0, "Pilsner", 7.5, "CarlsbergPilsner.jpg"),
                new Item(1, "IPA", 8.5, "CarlsbergIPA.jpg"),
                new Item(2, "Jul",10,"CarlsbergJul.jpg"),
                new Item(3, "Sport", 7.5, "Sport.jpg"),
                new Item(4, "Special",10,"CarlsbergSpecial.jpg"),
            };

            //Db call to get all items
            var items = new BLL.BLL.ItemBLL().GetAllItems();
            return View("Index", items);
        }
        
        public ActionResult EditItem(int id)
        {
            //CALL TO DATABASE!!!! any way
            var items = new List<Item>
            {
                new Item(0, "Pilsner", 7.5, "CarlsbergPilsner.jpg"),
                new Item(1, "IPA", 8.5, "CarlsbergIPA.jpg"),
                new Item(2, "Jul",10,"CarlsbergJul.jpg"),
                new Item(3, "Sport", 7.5, "Sport.jpg"),
                new Item(4, "Special",10,"CarlsbergSpecial.jpg"),
            };
            var fromlist = items[id];

            return PartialView("_EditItem", fromlist);
        }
        public ActionResult SaveItem(Item item)
        {
            //Save the item to the database
            return RedirectToAction("Index", "Home");
        }
        public ActionResult DeleteItem(int id)
        {
            //Do stuff here to remove the item from the database
            //Dont actually delete the item, just set a flag to mark it as deleted
            
            //If error, 
            return RedirectToAction("Index", "Item");
        }
    }
}