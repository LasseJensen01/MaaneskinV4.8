using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>(); // This is cursed

        public Order() {
            
        }
        public Order(int id)
        {
            ID = id;
            Date = DateTime.Now;
        }

        public void AddOrderLine(OrderLine orderLine) {
            this.OrderLines.Add(orderLine);
        }
        public bool RemoveOrderline(OrderLine orderLine) {
            return this.OrderLines.Remove(orderLine);
        }
        public double GetTotalOrderPrice()
        {
            double total = 0;
            foreach (OrderLine orderLine in OrderLines)
            {
                total += orderLine.TotalPrice;
            }
            return total;
        }

        public double GetTotalSalePrice()
        {
            double total = 0;
            foreach (OrderLine orderLine in OrderLines)
            {
                total += orderLine.GetTotal();
            }
            return total;
        }
        public override string ToString()
        {
            string orderString = "";
            foreach (OrderLine orderLine in OrderLines)
            {
                orderString += orderLine.ToString() + "\n";
            }
            orderString += $"Total: {GetTotalSalePrice()} kr.";
            return orderString;
        }
    }
}