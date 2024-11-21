using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper {
    public class OrderMapper {
        public static DTO.Models.Order Map(Order order) {
            DTO.Models.Order retur = new DTO.Models.Order(order.ID);
            foreach(OrderLine orderline in order.OrderLines) {
                retur.AddOrderLine(OrderLineMapper.Map(orderline));
            }
            return retur;
        }

        public static Order Map(DTO.Models.Order order) {
            Order retur = new Order(order.ID);
            foreach(DTO.Models.OrderLine orderline in order.OrderLines) {
                retur.AddOrderLine(OrderLineMapper.Map(orderline));
            }
            return retur;

        }

        public static void Update(DTO.Models.Order order, Order dataOrder) {
            //TODO
        }

        public static List<DTO.Models.Order> Map(List<Order> orders) {
            //TODO
            return null;
        }
        public static List<Order> Map(List<DTO.Models.Order> orders) {
            //TODO
            return null;
        }
    }
}
