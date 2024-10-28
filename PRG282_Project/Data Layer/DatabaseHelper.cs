using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    internal class DatabaseHelper : IStudentRepository
    {
        private string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void LoadStudentData(DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT * FROM Students ";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        // Method to get the last student number
        public string GetLastStudentNumber()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 [Student number] FROM Students ORDER BY [Student number] DESC";
                SqlCommand cmd = new SqlCommand(query, conn);

                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
        }

        private string GenerateNextStudentNumber(string lastStudentNumber)
        {
            if (string.IsNullOrEmpty(lastStudentNumber))
            {
                return "S001"; // Start from S001 if no records exist
            }

            // Extract the numeric part, increment, and format with leading zeros
            int numericPart = int.Parse(lastStudentNumber.Substring(1)) + 1;
            return "S" + numericPart.ToString("D3");
        }

        public void InsertStudent(string studentName, int studentAge, string course)
        {
            string lastStudentNumber = GetLastStudentNumber();
            string newStudentNumber = GenerateNextStudentNumber(lastStudentNumber);

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"
            INSERT INTO Students ([Student number], [Student Name], [Student Age], [Course])
            VALUES (@StudentNumber, @StudentName, @StudentAge, @Course);";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentNumber", newStudentNumber);
                cmd.Parameters.AddWithValue("@StudentName", studentName);
                cmd.Parameters.AddWithValue("@StudentAge", studentAge);
                cmd.Parameters.AddWithValue("@Course", course);

                conn.Open();
                cmd.ExecuteNonQuery();


            }
        }

        public bool DeleteStudent(string studentId)
        {
            try
            {
                // Assume using connection and command objects
                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE [Student number] = @StudentId", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                // Log or handle exceptions as necessary
                return false;
            }
        }
    }
}
