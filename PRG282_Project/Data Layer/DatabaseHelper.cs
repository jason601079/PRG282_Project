using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.Business_Logic_Layer;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

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

        public void LoadHomePageData(Label lbl, Label lbl2)
        {
            string connection = _connectionString;
            string query = @"SELECT COUNT(s.Gender)
FROM dbo.Students s
WHERE s.Gender = 'Male'";
            string query2 = @"SELECT COUNT(s.Gender)
FROM dbo.Students s
WHERE s.Gender = 'Female'";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        object result = command.ExecuteScalar();
                        lbl.Text = "Male: " + result;

                    }

                    using (SqlCommand command2 = new SqlCommand(query2, conn))
                    {
                        object result2 = command2.ExecuteScalar();
                        lbl2.Text = "Female: " + result2;

                    }

                    conn.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void LoadTop5Achievers(DataGridView dgv)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT TOP 5 m.[Student number],CONCAT(s.[First name], ' ', s.[Last name]) AS FullName,AVG(m.Mark) AS AverageMark
FROM dbo.Modules AS m
JOIN dbo.Students AS s
ON 
m.[Student number] = s.[Student number]
GROUP BY 
    m.[Student number], 
    s.[First name], 
    s.[Last name]
ORDER BY 
    AverageMark DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
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

        public void bcomStd(Label lbl)
        {
            string connectionString = _connectionString;
            string query = @"SELECT COUNT(s.Course)
FROM dbo.Students s
WHERE s.Course = 'BCOMP'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {

                    connection.Open();

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    // Set the label's text to the result (handle null values)
                    if (result != DBNull.Value)
                    {
                        lbl.Text = result.ToString();
                    }
                    else
                    {
                        lbl.Text = "No data available.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public void biStd(Label lbl)
        {
            string connectionString = _connectionString;
            string query = @"SELECT COUNT(s.Course)
FROM dbo.Students s
WHERE s.Course = 'BI'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {

                    connection.Open();

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    // Set the label's text to the result (handle null values)
                    if (result != DBNull.Value)
                    {
                        lbl.Text = result.ToString();
                    }
                    else
                    {
                        lbl.Text = "No data available.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public void diplomaStd(Label lbl)
        {
            string connectionString = _connectionString;
            string query = @"SELECT COUNT(s.Course)
FROM dbo.Students s
WHERE s.Course = 'Diploma'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {

                    connection.Open();

                    // Execute the query and get the result
                    object result = command.ExecuteScalar();

                    // Set the label's text to the result (handle null values)
                    if (result != DBNull.Value)
                    {
                        lbl.Text = result.ToString();
                    }
                    else
                    {
                        lbl.Text = "No data available.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        public void PopulateDoughnutChart(Chart chart2)
        {
            // Connection string to your database
            string connectionString = _connectionString;

            // SQL query to get the top 7 modules with counts of passed marks
            string query = @"SELECT TOP 7 m.Module, COUNT(m.Mark) as passed
                     FROM dbo.Modules m
                     WHERE m.Mark > 49
                     GROUP BY m.Module
                     ORDER BY passed DESC";

            // Initialize database connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand to execute the query
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                // Fill the DataTable with the query result
                adapter.Fill(dt);

                // Clear existing data points in the series
                chart2.Series["s1"].Points.Clear();

                // Loop through the DataTable rows and add data points to the series
                foreach (DataRow row in dt.Rows)
                {
                    string moduleName = row["Module"].ToString();
                    int passedCount = Convert.ToInt32(row["passed"]);

                    // Add data point
                    chart2.Series["s1"].Points.AddXY(moduleName, passedCount);
                }

                // Set chart type to Doughnut
                chart2.Series["s1"].ChartType = SeriesChartType.Doughnut;

                // Optional: Customize the Doughnut chart appearance
                chart2.Series["s1"]["PieLabelStyle"] = "Inside";
                chart2.Series["s1"].IsValueShownAsLabel = true;
                chart2.Series["s1"].LabelForeColor = System.Drawing.Color.White;
            }

        }

        public void top5FailedModules(DataGridView dgv)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT TOP 8 m.Module, COUNT(m.Mark) AS Failed
FROM dbo.Modules m
WHERE m.Mark < 50
GROUP BY m.Module
ORDER BY Failed DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
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

    }
}
