using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGUI.Models;

namespace WebGUI.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index()
        {
            //Get all items from the database, for now just create some dummy items
            var items = new List<Item>
            {
                new Item("Pilsner", 7.5, "CarlsbergPilsner.jpg"),
                new Item("IPA", 8.5, "CarlsbergIPA.jpg"),
                new Item("Jul",10,"CarlsbergJul.jpg"),
                new Item("Sport", 7.5, "Sport.jpg"),
                new Item("Special",10,"CarlsbergSpecial.jpg"),
            };
            ViewBag.ID = items[0].ID;

            return View("Index", items);
        }
        // GET: Item
        public ActionResult EditItem(int ID)
        {
            //CALL TO DATABASE!!!! any way

            //Replace this with a parameter (name?) that retrives the item from the database
            var imageName = "CarlsbergPilsner.jpg";
            var item = new Item("Pilsner", 7.5, imageName);

            return View("EditItem", item);
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