using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL {
    public class ItemBLL {
        public DTO.Models.Item GetItem(int id) {
            return DAL.Repositories.ItemRepositorie.GetItem(id);
        }
        public List<DTO.Models.Item> GetAllItems() {
            return DAL.Repositories.ItemRepositorie.GetAllItems();
        }
        public void AddItem(DTO.Models.Item item) {
            DAL.Repositories.ItemRepositorie.AddItem(item);
        }
        public void UpdateItem(DTO.Models.Item item) {
            DAL.Repositories.ItemRepositorie.UpdateItem(item);
        }

    }
}
