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
            Order headerOrder = new Order();
            ViewBag.Order = headerOrder;

            OrderBLL bll = new OrderBLL();
            List<DTO.Models.Order> orders = bll.GetAllOrders();
            
            
            return View("OrderOverview", orders);
        }
    }
}