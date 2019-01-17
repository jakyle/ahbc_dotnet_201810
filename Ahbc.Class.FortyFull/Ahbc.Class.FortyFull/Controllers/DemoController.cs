using Ahbc.Class.FortyFull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ahbc.Class.FortyFull.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(DemoInputModel model)
        {
            if (ModelState.IsValid)
            {
                var count = 0;
                var cookie = Request.Cookies.Get("valid-save");
                if (cookie != null)
                {
                    count = int.TryParse(cookie.Value, out var num) ? num : 0;
                }
                count++;
                Response.SetCookie(new HttpCookie("valid-save", count.ToString()));


                // Save to database here
                Session["LastSaved"] = DateTime.Now.ToShortTimeString();
                TempData["EditResult"] = "Data successfully saved";
                return RedirectToRoute(new { controller="Home", action = "Index" });
            }

            return View("Index", model);
        }
    }
}