using GetApp.Areas.AdminInterface.Filters;
using GetApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace GetApp.Areas.AdminInterface.Controllers
{
    [AdminAuthenticationFilter]
    public class AccountSettingController : Controller
    {
        GetModel db = new GetModel();
        // GET: AdminInterface/AccountSetting
        [HttpGet]
        public ActionResult Edit()
        {
            Maneger m = (Maneger)Session["adminSession"];
            return View(m);
        }
        [HttpPost]
        public ActionResult Edit(Maneger model, HttpPostedFileBase profilImage)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (profilImage != null)
                    {
                        FileInfo fi = new FileInfo(profilImage.FileName);
                        string name = Guid.NewGuid().ToString() + fi.Extension;
                        model.ProfilImagesPath = name;
                        profilImage.SaveAs(Server.MapPath($"~/Areas/AdminInterface/Assets/Images/ProfilImages/{name}"));
                    }
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("LogOut", "Login");
                }
                catch
                {
                    ViewBag.Mesaj = "Hesap Düzenlenirken Bir Hata Oluştu";
                }
            }
            return View(model);
        }
    }
}