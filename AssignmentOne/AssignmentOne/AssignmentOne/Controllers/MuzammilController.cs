using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentOne.Controllers
{
    public class MuzammilController : Controller
    {
        // GET: MuzammilController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Khairu()
        {
            return View();
        }


        // GET: MuzammilController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MuzammilController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MuzammilController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MuzammilController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MuzammilController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MuzammilController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MuzammilController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
