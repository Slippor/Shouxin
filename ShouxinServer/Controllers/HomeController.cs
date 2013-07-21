using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShouxinServer.Common;
using ShouxinServer.ViewModels;

namespace ShouxinServer.Controllers
{
    public class HomeViewModel : BaseViewModel
    {
        public override List<string> CustomCssPathes
        {
            get
            {
                return new List<string>() { StyleConfigs.HomeIndexCssVirtualPath };
            }
            set
            {
                base.CustomCssPathes = value;
            }
        }
    }

    public class HomeController : BaseController
    {
        protected override BaseViewModel GetViewModel()
        {
            return new HomeViewModel();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "手信首页";

            var viewModel = GetViewModel();
            return View(viewModel);
        }
    }
}
