using AssignmentOne.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentOne.Controllers
{
    public class AppController : Controller
    {
        // GET: AppController
        public ActionResult board()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitStudent(Student studentData)
        {
            // Do something with the form data, for example:
            // Save the student to a database, send an email notification, etc.
            // ...

            // Return a response to the user, for example:
            return Content($"Thank you, {studentData.name}, for submitting your information.");
        }

        // GET: AppController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppController/Create
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

        // GET: AppController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppController/Edit/5
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

        // GET: AppController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppController/Delete/5
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
