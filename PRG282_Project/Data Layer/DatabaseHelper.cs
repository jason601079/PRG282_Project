using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.Business_Logic_Layer;
using System.Windows.Forms;

namespace PRG282_Project
{
    internal class DatabaseHelper : IStudentRepository
    {


        private readonly string _connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";

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

        public void InsertStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Students ([Student number], [First name], [Last name], [Gender], [Student Age], [Course]) " +
                                   "VALUES (@StudentNumber, @FirstName, @LastName, @Gender, @Age, @Course)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                        command.Parameters.AddWithValue("@FirstName", student.FirstName);
                        command.Parameters.AddWithValue("@LastName", student.LastName);
                        command.Parameters.AddWithValue("@Gender", student.Gender);
                        command.Parameters.AddWithValue("@Age", student.Age);
                        command.Parameters.AddWithValue("@Course", student.Course);

                        command.ExecuteNonQuery();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }

            
        }

        public void DeleteStudent(string studentNumber)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Students WHERE [Student number] = @StudentNumber";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);

                cmd.ExecuteNonQuery(); // Execute the delete command
            }
        }

        public void UpdateStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Students SET [First name] = @FirstName, [Last name] = @LastName, " +
                               "[Student age] = @Age, [Course] = @Course, [Gender] = @Gender " +
                               "WHERE [Student number] = @StudentNumber";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Course", student.Course);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);

                cmd.ExecuteNonQuery();
            }
        }


    }
}
