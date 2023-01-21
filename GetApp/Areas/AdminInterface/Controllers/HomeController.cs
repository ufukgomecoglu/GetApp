using GetApp.Areas.AdminInterface.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetApp.Areas.AdminInterface.Controllers
{
    [AdminAuthenticationFilter]
    public class HomeController : Controller
    {
        // GET: AdminInterface/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}