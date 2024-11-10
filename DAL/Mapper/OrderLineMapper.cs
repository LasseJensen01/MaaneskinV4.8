using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper {
    public class OrderLineMapper {
        
        // We are gonne reach mapping lengths which shouldnt even be possible... This is what scaling is all about
        public static DTO.Models.OrderLine Map(Models.OrderLine orderLine) {
            if (orderLine != null) {
                return new DTO.Models.OrderLine(orderLine.ID, orderLine.Quantity, ItemMapper.Map(orderLine.Item));
            }
            else { return null; }
        }

        public static Models.OrderLine Map(DTO.Models.OrderLine orderLine) {
            if (orderLine != null) {
                return new Models.OrderLine(orderLine.ID, orderLine.Quantity, ItemMapper.Map(orderLine.Item));
            }
            else { return null; }
        }

        public static void Update(DTO.Models.OrderLine orderLine, Models.OrderLine dataOrderLine) {
            if (orderLine != null && dataOrderLine != null) {
                dataOrderLine.ID = orderLine.ID; //In general shouldnt be able to change ID at all on objects in sys, but keep in for now :D
                dataOrderLine.Quantity = orderLine.Quantity;
                dataOrderLine.Item = ItemMapper.Map(orderLine.Item);

            }
            else {
                dataOrderLine = null;
            }
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
        public static List<Models.OrderLine> Map(List<DTO.Models.OrderLine> orderLines) {
            List<Models.OrderLine> retur = new List<Models.OrderLine>();
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
