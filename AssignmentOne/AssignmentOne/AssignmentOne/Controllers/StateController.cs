using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace AssignmentOne.Controllers
{
    public class StateController : Controller
    {
        public ActionResult GetStates()
        {
            List<SelectListItem> states = new List<SelectListItem>();

            string connectionString = "Server=(local);Database=Arshad;User Id=opsuser;Password=Opt1mus;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, state FROM States ORDER BY state ASC"; // SQL query to retrieve all states ordered alphabetically
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Create a new SelectListItem object for each state and add it to the list
                        states.Add(new SelectListItem
                        {
                            Value = reader["id"].ToString(),
                            Text = reader["state"].ToString()
                        });
                    }
                    reader.Close();
                }
            }

            // Convert the list of SelectListItem objects to a JSON string
            string json = JsonConvert.SerializeObject(states);

            // Return the JSON string as a response to the AJAX call
            return Content(json, "application/json");
        }
    }
}
