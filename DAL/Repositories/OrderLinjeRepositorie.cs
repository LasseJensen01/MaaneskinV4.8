using DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories {
    public class OrderLinjeRepositorie {
        public static List<DTO.Models.OrderLine> GetAllOrderLinjes(int id) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                List<DAL.Models.OrderLine> orderLinjes = context.OrderLines.Where(ol => ol.OrderID == id).ToList();
                foreach (var order in orderLinjes) {
                    order.Item = context.Items.Find(order.ItemID);
                }
                return Mapper.OrderLineMapper.Map(orderLinjes);
            }
        }
    }
}
