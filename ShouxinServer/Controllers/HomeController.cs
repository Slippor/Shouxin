using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShouxinServer.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "手信首页";

            var viewModel = GetViewModel();
            return View(viewModel);
        }
    }
}
