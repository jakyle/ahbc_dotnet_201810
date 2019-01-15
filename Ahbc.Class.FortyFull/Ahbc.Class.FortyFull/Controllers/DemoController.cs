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
                // Maybe save this?
                return RedirectToRoute(new { controller="Home", action = "Index" });
            }

            return View("Index", model);
        }
    }
}