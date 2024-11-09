using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories {
    public class ItemRepositorie {
        public static DTO.Models.Item GetItem(int id) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Item item = context.Items.Find(id);
                return Mapper.ItemMapper.Map(item);
            }    
        }
        public static List<DTO.Models.Item> GetAllItems() {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                List<DAL.Models.Item> items = context.Items.ToList();
                return Mapper.ItemMapper.Map(items);
            }
        }
        public static void AddItem(DTO.Models.Item item) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Item dataitem = Mapper.ItemMapper.Map(item);
                context.Items.Add(dataitem);
                context.SaveChanges();
            }
        }
        public static void UpdateItem(DTO.Models.Item item) {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Item dataitem = context.Items.Find(item.ID);
                Mapper.ItemMapper.Update(item, dataitem);
                context.SaveChanges();
            }
        }
    }
}
