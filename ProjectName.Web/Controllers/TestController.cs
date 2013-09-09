using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectName.Web.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            int i = 15;
            int d = 0;
            int rs = i / d;
            ViewBag.rs = rs;
            return View();
        }

    }
}
