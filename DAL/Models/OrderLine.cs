using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class OrderLine {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public Item Item { get; set; }
        // Foreign key
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        //Foreign Key
        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public double TotalPrice {  get; set; }
       

        public OrderLine() { }

        public OrderLine(int id, int quantity, Item item)
        {
            ID = id;
            Quantity = quantity;
            Item = item;
            TotalPrice = GetTotal();
        }
        public double GetTotal()
        {
            return Quantity * Item.Price;
        }
    }
}