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
        // GET: Item
        public ActionResult EditItem()
        {
            //Replace this with a parameter (name?) that retrives the item from the database
            var imageName = "CarlsbergPilsner.jpg";
            var item = new Item("Pilsner", 7.5, imageName);

            return View("EditItem", item);
        }
    }
}