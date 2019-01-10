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
        public ActionResult Index(int? id)
        {
            var model = new DemoInputModel
            {
                FirstName = "Jason",
                MiddleName = "Timothy",
                LastName = "Robert",
                IsActive = true
            };

            return View(model);
        }
    }
}