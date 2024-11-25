using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper {
    public class OrderLineMapper {
        
        public static DTO.Models.OrderLine Map(Models.OrderLine orderLine) {
            if (orderLine != null) {
                DTO.Models.OrderLine ol = new DTO.Models.OrderLine(orderLine.ID, orderLine.Quantity, ItemMapper.Map(orderLine.Item));
                ol.TotalPrice = orderLine.TotalPrice;
                return ol;
            }
            else { return null; }
        }

        public static Models.OrderLine Map(DTO.Models.OrderLine orderLine) {
            if (orderLine != null) {
                return new Models.OrderLine(orderLine.ID, orderLine.Quantity, ItemMapper.Map(orderLine.Item));
            }
            else { return null; }
        }

        public static List<DTO.Models.OrderLine> Map(List<Models.OrderLine> orderLines) {
            List<DTO.Models.OrderLine> retur = new List<DTO.Models.OrderLine>();
            if (orderLines != null && orderLines.Count > 0) {
                foreach (var orderLine in orderLines) {
                    retur.Add(Map(orderLine));
                }
                return retur;
            }
            else {
                return null;
            }
        }
    }
}
