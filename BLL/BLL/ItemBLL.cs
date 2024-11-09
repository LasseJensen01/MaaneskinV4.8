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
    }
}
