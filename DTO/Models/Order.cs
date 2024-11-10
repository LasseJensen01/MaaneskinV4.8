using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Models
{
    public class Order
    {
        public int ID { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public Order(List<OrderLine> orderLines)
        {
            OrderLines = orderLines;
        }
        public double GetTotal()
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
            orderString += $"Total: {GetTotal()} kr.";
            return orderString;
        }
    }
}