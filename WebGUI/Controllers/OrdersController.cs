using BLL.BLL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGUI.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult OrderOverview()
        {
            /*
            List<DTO.Models.Order> orders = new List<DTO.Models.Order>();

            DTO.Models.Item cola = new DTO.Models.Item(1, "Cola", 10, "Harold.jpg", 10);
            DTO.Models.Item øl = new DTO.Models.Item(1, "Øl", 10, "Harold.jpg", 10);

            for (int i = 0; i < 5; i++)
            {
                DTO.Models.Order order = new DTO.Models.Order(i);

                DTO.Models.OrderLine ol;

                if (i % 2 == 0)
                {
                    ol = new DTO.Models.OrderLine(i, 1, cola);
                }
                else
                {
                    ol = new DTO.Models.OrderLine(i, 1, øl);
                }

                order.AddOrderLine(ol);
                order.AddOrderLine(ol);
                order.AddOrderLine(ol);
                order.AddOrderLine(ol);
                orders.Add(order);
            }
            */

            Order headerOrder = new Order();
            ViewBag.Order = headerOrder;

            OrderBLL bll = new OrderBLL();
            List<DTO.Models.Order> orders = bll.GetAllOrders();
            
            
            return View("OrderOverview", orders);
        }
    }
}