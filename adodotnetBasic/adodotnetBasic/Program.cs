using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adodotnetBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Corrected SQL queries with parameters
            string insertQuery = "INSERT INTO marklist (student_id, maths, science, english) VALUES (@StudentId, @Maths, @Science, @English)";
            string selectQuery = "SELECT maths FROM marklist WHERE student_id = @StudentId";
            string updateQuery = "UPDATE marklist SET maths = @Maths WHERE student_id = @StudentId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Start a transaction
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Insert query
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@StudentId", 8);
                        cmdInsert.Parameters.AddWithValue("@Maths", 45);
                        cmdInsert.Parameters.AddWithValue("@Science", 23);
                        cmdInsert.Parameters.AddWithValue("@English", 45);
                        cmdInsert.ExecuteNonQuery();
                    }
                    // Update an existing record
                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@StudentId", 1);
                        cmdUpdate.Parameters.AddWithValue("@Maths", 11);
                        cmdUpdate.ExecuteNonQuery();
                    }
                    // Commit the transaction
                    transaction.Commit();
                    Console.WriteLine("Transaction committed successfully.");

                    // Now perform a SELECT query to retrieve data
                    int maths;
                    using (SqlCommand cmdSelect = new SqlCommand(selectQuery, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@StudentId", 8);
                        object result = cmdSelect.ExecuteScalar();
                    }
                    // Check if the result is not null
                    if (result != null)
                    {
                        maths = Convert.ToInt32(result);
                        Console.WriteLine($"Current Maths Score: {maths}");
                    }
                    else
                    {
                        Console.WriteLine("Record not found.");
                    }
                }
                catch (Exception ex)
                {
                    // Roll back the transaction if an error occurs
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back. Error: " + ex.Message);
                }
            }
        }

    }
}
