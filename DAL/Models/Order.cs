using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Order {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public Order() {

        }
        public Order(int id) {
            ID = id;
            Date = DateTime.Now;
        }

        public void AddOrderLine(OrderLine orderLine) {
            this.OrderLines.Add(orderLine);
        }
    }
}