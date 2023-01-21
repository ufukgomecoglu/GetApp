using GetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetApp.Areas.AdminInterface.Controllers
{
    public class LoginController : Controller
    {
        GetModel db = new GetModel();
        // GET: AdminInterface/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string mail, string password)
        {
            if (ModelState.IsValid)
            {
                int sayi = db.Manegers.Count(s => s.Mail == mail && s.Password == password);
                if (sayi > 0)
                {
                    Maneger m = db.Manegers.First(s => s.Mail == mail && s.Password == password);
                    if (m.IsActive)
                    {
                        Session["adminSession"] = m;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.message = "Kullanıcı aktif değil";
                    }
                }
                else
                {
                    ViewBag.message = "Kullanıcı bulunamadı";
                }
            }

            return View();
        }
        public ActionResult LogOut()
        {
            Session["adminSession"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}