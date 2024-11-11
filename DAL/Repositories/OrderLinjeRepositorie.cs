using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories {
    public class OrderLinjeRepositorie {
        public static DTO.Models.OrderLine GetOrderLinje(int id) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.OrderLine orderLinje = context.OrderLines.Find(id);
                return Mapper.OrderLineMapper.Map(orderLinje);
            }
        }
        public static List<DTO.Models.OrderLine> GetAllOrderLinjes() {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                List<DAL.Models.OrderLine> orderLinjes = context.OrderLines.ToList();
                return Mapper.OrderLineMapper.Map(orderLinjes);
            }
        }
        public static void AddOrderLinje(DTO.Models.OrderLine orderLinje) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.OrderLine dataOrderLinje = Mapper.OrderLineMapper.Map(orderLinje);
                context.OrderLines.Add(dataOrderLinje);
                context.SaveChanges();
            }
        }
        public static void UpdateOrderLinje(DTO.Models.OrderLine orderLinje) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.OrderLine dataOrderLinje = context.OrderLines.Find(orderLinje.ID);
                Mapper.OrderLineMapper.Update(orderLinje, dataOrderLinje);
                context.SaveChanges();
            }
        }
    }
}
