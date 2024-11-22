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
                //hiv orderlines med
                List<DAL.Models.OrderLine> orderLines = context.OrderLines.ToList();
                foreach (DAL.Models.OrderLine line in orderLines)
                {
                    DTO.Models.OrderLine currentOl = Mapper.OrderLineMapper.Map(line);
                    orders.Find(o => o.ID == currentOl.ID);
                }
                //for hver ordrelinje
                    //find ordre i orders der matcher på id og tilføj
                return Mapper.OrderMapper.Map(orders);
            }
        }
        public static void AddOrder(DTO.Models.Order order) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Order dataOrder = Mapper.OrderMapper.Map(order);
                

                foreach (Models.OrderLine ol in dataOrder.OrderLines) {
                    ol.Item.Quantity = ol.Item.Quantity - ol.Quantity;
                    ItemRepositorie.UpdateItem(Mapper.ItemMapper.Map(ol.Item)); //Technically Redundant
                    // Accidentally made this entire class able save Order, Orderline and Item in DB
                    // Tells the DbContext the item changes are a modification and shouldnt create a new table element
                    // For this object
                    context.Entry(ol.Item).State = System.Data.Entity.EntityState.Modified;
                }
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
