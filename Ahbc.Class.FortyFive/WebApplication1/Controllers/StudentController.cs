using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
		private readonly SchoolContext _context = new SchoolContext();

		// GET: Student
		public ActionResult Index()
        {

			var students = _context.Students;


			var test = 2;

            return View(students);
        }
    }
}