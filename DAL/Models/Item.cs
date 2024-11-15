using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
        public bool IsDeleted { get; set; }
        public Item(int id, string name, double price, string imgURL, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            ImgURL = imgURL;
            Quantity = quantity;

            IsDeleted = false;
        }
        public Item() { }
    }
}