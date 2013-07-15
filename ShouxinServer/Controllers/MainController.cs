using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShouxinServer.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/
        public ActionResult Index()
        {
            ViewBag.Menu = new List<String> {
				"我的手信","账户管理",
				"交易记录","会员保障","应用中心"
            };
            return View();
        }
    }
}
