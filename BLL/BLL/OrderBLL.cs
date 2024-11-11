using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL {
    public class OrderBLL {
        public DTO.Models.Order GetOrder(int id) {
            return DAL.Repositories.OrderRepositorie.GetOrder(id);
        }
        public List<DTO.Models.Order> GetAllOrders() {
            return DAL.Repositories.OrderRepositorie.GetAllOrders();
        }
        public void AddOrder(DTO.Models.Order order) {
            DAL.Repositories.OrderRepositorie.AddOrder(order);
        }
        public void UpdateOrder(DTO.Models.Order order) {
            DAL.Repositories.OrderRepositorie.UpdateOrder(order);
        }

    }
}
