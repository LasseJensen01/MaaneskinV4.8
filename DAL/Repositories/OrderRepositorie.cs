using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories {
    public class OrderRepositorie {
        public static DTO.Models.Order GetOrder(int id) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Order order = context.Orders.Find(id);
                DTO.Models.Order DTOOrder = Mapper.OrderMapper.Map(order);
                DTOOrder.OrderLines = OrderLinjeRepositorie.GetAllOrderLinjes(DTOOrder.ID);
                return DTOOrder;
            }
        }
        public static List<DTO.Models.Order> GetAllOrders() {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                List<DAL.Models.Order> orders = context.Orders.ToList();
                return Mapper.OrderMapper.Map(orders);
            }
        }
        public static void AddOrder(DTO.Models.Order order) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Order dataOrder = Mapper.OrderMapper.Map(order);
                context.Orders.Add(dataOrder);
                context.SaveChanges();
            }
        }
        public static void UpdateOrder(DTO.Models.Order order) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Order dataOrder = context.Orders.Find(order.ID);
                Mapper.OrderMapper.Update(order, dataOrder);
                context.SaveChanges();
            }
        }
    }
}
