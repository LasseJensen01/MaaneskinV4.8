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
        public static void AddItem(DTO.Models.Item item) {
            // TODO
        }
    }
}
