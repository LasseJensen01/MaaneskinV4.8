using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Models
{
    public class OrderLine
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public Item Item { get; set; }

        public OrderLine(int id, int quantity, Item item)
        {
            ID = id;
            Quantity = quantity;
            Item = item;
        }
        public double GetTotal()
        {
            return Quantity * Item.Price;
        }
        public override string ToString()
        {
            return $"{Quantity} x {Item.Name} = {Item.Price}DKK.";
        }
    }
}