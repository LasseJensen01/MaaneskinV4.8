﻿using System;
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
                new Item(0, "Pilsner", 7.5, "CarlsbergPilsner.jpg"),
                new Item(1, "IPA", 8.5, "CarlsbergIPA.jpg"),
                new Item(2, "Jul",10,"CarlsbergJul.jpg"),
                new Item(3, "Sport", 7.5, "Sport.jpg"),
                new Item(4, "Special",10,"CarlsbergSpecial.jpg"),
            };

            return View("Index", items);
        }
        // GET: Item
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

            //Replace this with a parameter (name?) that retrives the item from the database
            var imageName = "Harold.jpg";
            var item = new Item(8, "Harold", 7.5, imageName);

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