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
            return View(ItemBLL.GetItem(0));
        }
    }
}