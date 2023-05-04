using AssignmentOne.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentOne.Controllers
{
    public class AmjadController : Controller
    {
        // GET: AmjadController

       
        public ActionResult Mama()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult SubmitData1(Studentdata dataStudent)
        {
            // Do something with the form data, for example:
            // Save the student to a database, send an email notification, etc.
            // ...

            // Return a response to the user, for example:
            return Content($"Thank you, {dataStudent.fName} {dataStudent.lName} {dataStudent.myEmail}{dataStudent.myPhone}, for submitting your information.");
        }
    

        
    // GET: AmjadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AmjadController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AmjadController/Create
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

        // GET: AmjadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AmjadController/Edit/5
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

        // GET: AmjadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AmjadController/Delete/5
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
