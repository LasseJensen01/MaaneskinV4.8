using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Order {
        public int ID { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>(); // This is cursed
        public Order() {

        }
        public Order(int id) {
            ID = id;
        }

        public void AddOrderLine(OrderLine orderLine) {
            this.OrderLines.Add(orderLine);
        }
        public bool RemoveOrderline(OrderLine orderLine) {
            return this.OrderLines.Remove(orderLine);
        }
        public double GetTotal() {
            double total = 0;
            foreach (OrderLine orderLine in OrderLines) {
                total += orderLine.GetTotal();
            }
            return total;
        }
        public override string ToString() {
            string orderString = "";
            foreach (OrderLine orderLine in OrderLines) {
                orderString += orderLine.ToString() + "\n";
            }
            orderString += $"Total: {GetTotal()}DKK.";
            return orderString;
        }
    }
}