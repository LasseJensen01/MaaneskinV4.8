﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace DTO.Models
{
    public class Item
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
        public int Quantity { get; set; }
        public Item(string name, double price, string imgURL, int quantity)
        {
            ID = IDIncrementClass.GenerateID();
            Name = name;
            Price = price;
            ImgURL = imgURL;
            Quantity = quantity;
        }
        // Made for Mappers
        public Item(int id, string name, double price, string imgURL, int quantity) {
            ID = id;
            Name = name;
            Price = price;
            ImgURL = imgURL;
            Quantity = quantity;
        }
        public Item() { }
    }
}