using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShouxinServer.Controllers
{
    public class AboutController : BaseController
    {
        //
        // GET: /Abount/
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View(GetViewModel());
        }
    }
}
