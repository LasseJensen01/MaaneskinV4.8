using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGUI.Models
{
    public class Inventory
    {
        public Dictionary<Item, int> Items { get; set; }
    }
}