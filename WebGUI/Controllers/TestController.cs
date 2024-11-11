using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGUI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            BLL.BLL.ItemBLL ItemBLL = new BLL.BLL.ItemBLL();
            
            return View(ItemBLL.GetItem(4));
        }
        public ActionResult TestOrder() {
            BLL.BLL.OrderBLL OrderBLL = new BLL.BLL.OrderBLL();
            return View(OrderBLL.GetOrder(1));
        }
    }
}