using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebGUI.Models
{
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }

        public Item(string name, double price, string imgURL)
        {
            Name = name;
            Price = price;
            ImgURL = imgURL;
        }
        public Item() { }
    }
}