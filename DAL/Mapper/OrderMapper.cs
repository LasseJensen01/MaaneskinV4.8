using DAL.Models;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper {
    public class OrderMapper {
        public static DTO.Models.Order Map(DAL.Models.Order order) {
            DTO.Models.Order retur = new DTO.Models.Order(order.ID);
            retur.Date = order.Date;
            foreach(DAL.Models.OrderLine orderline in order.OrderLines) {
                retur.AddOrderLine(OrderLineMapper.Map(orderline));
            }
            
            return retur;
        }

        public static DAL.Models.Order Map(DTO.Models.Order order) {
            DAL.Models.Order retur = new DAL.Models.Order(order.ID);
            order.Date = retur.Date;
            foreach(DTO.Models.OrderLine orderline in order.OrderLines) {
                retur.AddOrderLine(OrderLineMapper.Map(orderline));
            }
            return retur;

        }

        public static List<DTO.Models.Order> Map(List<DAL.Models.Order> orders) {
            List<DTO.Models.Order> newOrders = new List<DTO.Models.Order>();
            if (orders != null && orders.Count >= 0)
            {
                foreach (DAL.Models.Order order in orders)
                {
                    newOrders.Add(Map(order));
                }
                return newOrders;
            }

            return null;
        }
    }
}
