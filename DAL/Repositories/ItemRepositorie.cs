using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories {
    public class ItemRepositorie {
        public static DTO.Models.Item GetItem(int id) 
        {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext()) {
                Models.Item item = context.Items.Find(id);
                return Mapper.ItemMapper.Map(item);
            }    
        }

        public static List<DTO.Models.Item> GetItems()
        {
            using (Context.MaaneskinContext context = new Context.MaaneskinContext())
            {
                var itemsDAL = context.Items.ToList();
                var itemsDTO = Mapper.ItemMapper.Map(itemsDAL);
                itemsDTO.Sort(/*inset comparer if no work*/);

                return itemsDTO;
            }
        }

        public static void AddItem(DTO.Models.Item item) {
            // TODO
        }
    }
}
