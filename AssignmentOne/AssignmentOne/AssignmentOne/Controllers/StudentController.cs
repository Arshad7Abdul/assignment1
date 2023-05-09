using AssignmentOne.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace AssignmentOne.Controllers
{
    public class StudentController : Controller
    {
        string connectionString = "Server=(local);Database=Arshad;User Id=opsuser;Password=Opt1mus;";

        public ActionResult DisplayStudentData()
        {
            // Define the connection string

                // Create a list to store the data
                List<Student> myData = new List<Student>();

                // Connect to the database and execute the query
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, Name, Email, Phone FROM Student";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Loop through the results and add them to the list
                            while (reader.Read())
                            {
                                Student dataItem = new Student();
                                dataItem.Id = (int)reader["Id"];
                                dataItem.name = (string)reader["Name"];
                                dataItem.email = (string)reader["Email"];
                                dataItem.phone = (int)reader["Phone"];
                                myData.Add(dataItem);
                            }
                        }
                    }
                    connection.Close();
                }

                // Pass the data to the view
                return View(myData);
            }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Retrieve the data to be edited from the database
            Student myData;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Student WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        myData = new Student()
                        {
                            Id = (int)reader["Id"],
                            name = (string)reader["Name"],
                            email = (string)reader["Email"],
                            phone = (int)reader["Phone"]
                        };
                    }
                }
                connection.Close();
            }

            // Pass the data to the view
            return View(myData);
        }

        [HttpPost]
        public IActionResult Edit(Student myData)
        {
            // Update the data in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE dbo.Student SET Name = @name, Email = @email, Phone = @phone WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", myData.name);
                    command.Parameters.AddWithValue("@email", myData.email);
                    command.Parameters.AddWithValue("@phone", myData.phone);
                    command.Parameters.AddWithValue("@id", myData.Id);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            // Redirect to the updated data view
            return RedirectToAction("DisplayStudentData");
        }

        public ActionResult Delete(int id)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Student WHERE Id = @Id";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        // Handle the case where the record doesn't exist
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception
                }
            }

            // Pass the data to the view
            return Content($"Thank you, {rowsAffected} rows are deleted.");
        }



    }
}
