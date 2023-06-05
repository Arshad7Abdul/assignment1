using AssignmentOne.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;



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

            string connectionString = @"Data Source=(local);Initial Catalog=Amjad;User ID=opsuser;Password=Opt1mus;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Define the SQL query with parameters
                string query = "INSERT INTO dbo.amjadDetails (fName, lName, myAdd, myEmail, myPhone, myGender, myTech, mySubmitDate, myTerms) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9)";

                // Create a command object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@value1", dataStudent.fName);
                    command.Parameters.AddWithValue("@value2", dataStudent.lName);
                    command.Parameters.AddWithValue("@value3", dataStudent.myAdd);
                    command.Parameters.AddWithValue("@value4", dataStudent.myEmail);
                    command.Parameters.AddWithValue("@value5", dataStudent.myPhone);
                    command.Parameters.AddWithValue("@value6", dataStudent.myGender);
                    command.Parameters.AddWithValue("@value7", dataStudent.myTech);
                    command.Parameters.AddWithValue("@value8", dataStudent.mySubmitTime);
                    command.Parameters.AddWithValue("@value9", dataStudent.myTerms);
                   

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
            return Content($"Thank you, {dataStudent.fName} {dataStudent.lName}, for submitting your information.");
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
