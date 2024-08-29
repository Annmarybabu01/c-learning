using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace adodotnetlearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the connection string
            string connectionString = "Server=LAPTOP-UETMEETT\\SQLEXPRESS01;Database=learning;Integrated Security=True;";
            string selectQuery = "SELECT maths FROM marklist";
            string updateQuery = "UPDATE marklist SET maths=11 WHERE id=1";
            // Create a SqlConnection object within a using statement
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object with the query and connection
                SqlCommand command = new SqlCommand(selectQuery, connection);
                try
                {
                    // Open the connection
                    connection.Open();
                    // Execute the query and retrieve the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there are rows to read
                        if (reader.HasRows)
                        {
                            // Loop through each row
                            while (reader.Read())
                            {
                                // Retrieve data for each column in the current row
                                // Assuming "maths" column is of type int or string
                                string maths = reader["maths"].ToString();
                                // Output the data
                                Console.WriteLine($"Maths Score: {maths}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rows found.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Handle SQL exceptions
                    Console.WriteLine("SQL Exception: " + ex.Message);
                }
            }
        }
    }
}
