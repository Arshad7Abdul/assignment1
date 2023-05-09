using AssignmentOne.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

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

            string connectionString = @"Data Source=(local);Initial Catalog=Arshad;User ID=opsuser;Password=Opt1mus;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query with parameters
                string query = "INSERT INTO dbo.Student (Name, Email, Phone) VALUES (@value1, @value2, @value3)";

                // Create a command object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@value1", studentData.name);
                    command.Parameters.AddWithValue("@value2", studentData.email);
                    command.Parameters.AddWithValue("@value3", studentData.phone);

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Data inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No data inserted.");
                    }
                }

                // Close the connection
                connection.Close();
            }


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
