using System.Web.Mvc;

namespace Ahbc.Class.FortyFull.Controllers
{
    public class ConventionController : Controller
    {
        // GET: Convention
        public ActionResult Index()
        {
            // This should show us a list of Entities
            return View();
        }

        // GET: Convention/Details/5
        public ActionResult Details(int id)
        {
            // This should show us the details of a single entity
            return View();
        }

        // GET: Convention/Create
        public ActionResult Create()
        {
            // This should give us an add form
            return View();
        }

        // POST: Convention/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            // Handles create request 
            return RedirectToAction("Index");
        }

        // GET: Convention/Edit/5
        public ActionResult Edit(int id)
        {
            // Edit for for a specific item
            return View();
        }

        // POST: Convention/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            // This would handle our Edit POST request
            return RedirectToAction("Index");
        }

        // GET: Convention/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
