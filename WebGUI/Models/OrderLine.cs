using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebGUI.Models
{
    public class OrderLine
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public Item Item { get; set; }

        public OrderLine(int quantity, Item item)
        {
            Quantity = quantity;
            Item = item;
        }
        public double GetTotal()
        {
            return Quantity * Item.Price;
        }
        public override string ToString()
        {
            return $"{Quantity} x {Item.Name} à {Item.Price} kr.";
        }
    }
}