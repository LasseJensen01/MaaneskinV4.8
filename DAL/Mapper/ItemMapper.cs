using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper {
    public class ItemMapper {

        public static DTO.Models.Item Map(Models.Item item) {
            if (item != null) {
                return new DTO.Models.Item(item.ID, item.Name, item.Price, item.ImgURL, item.Quantity);
            }
            else { return null; }
        }

        public static Models.Item Map(DTO.Models.Item item) {
            if (item != null) {
                return new Models.Item(item.ID, item.Name, item.Price, item.ImgURL, item.Quantity);
            }
            else { return null; }
        }
        public static void Update(DTO.Models.Item item, Models.Item dataitem) {
            if (item != null && dataitem != null) {
                dataitem.ID = item.ID;
                dataitem.Name = item.Name;
                dataitem.Price = item.Price;
                dataitem.ImgURL = item.ImgURL;
                dataitem.Quantity = item.Quantity;
            }
            else {
                dataitem = null;
            }
        }
        public static List<DTO.Models.Item> Map(List<Models.Item> items) {
            List<DTO.Models.Item> retur = new List<DTO.Models.Item>();
            if (items != null && items.Count > 0) {
                foreach (var item in items) {
                    retur.Add(new DTO.Models.Item(item.ID, item.Name, item.Price, item.ImgURL, item.Quantity));
                }
                return retur;
            }
            else {
                return null;
            }
        }
    }
}
