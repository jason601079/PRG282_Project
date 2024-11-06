using Guna.UI2.WinForms;
using PRG282_Project.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.Presentation_Layer
{
    public partial class ApplicantViewer : Form
    {
        private string selectedApplicantID;
        //private string _connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
        //public string applicantPath = @"C:\Users\taylo\Documents\PRG282\PRG282_Project\bin\Debug\Applicant.txt";
        //public string studentsFilePath = @"C:\Users\taylo\Documents\PRG282\PRG282_Project\bin\Debug\Students.txt";
        
        public string applicantPath = @"C:\Users\User\OneDrive\Desktop\Project_Prg282\Applicant.txt";
        public string studentsFilePath = @"C:\Users\User\OneDrive\Desktop\Project_Prg282\Students.txt";
        private  string _connectionString = @"Server=TRENT\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
        public ApplicantViewer()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void ApplicantViewer_Load(object sender, EventArgs e)
        {


            dataGridView1.Columns.Add("applicantID", "Applicant ID");
            dataGridView1.Columns.Add("SaID_number", "SA ID Number");
            dataGridView1.Columns.Add("firstname", "First Name");
            dataGridView1.Columns.Add("lastname", "Last Name");
            dataGridView1.Columns.Add("Course", "Course");
            dataGridView1.Columns.Add("email", "Email");
            dataGridView1.Columns.Add("documentPath", "Document Path");

            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;


            LoadDataIntoDataGridView();

        }

        private void LoadDataIntoDataGridView()
        {

            


            if (File.Exists(applicantPath))
            {

                var lines = File.ReadAllLines(applicantPath);


                foreach (var line in lines)
                {

                    var data = line.Split(',');


                    if (data.Length == 7)
                    {

                        dataGridView1.Rows.Add(data);
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                selectedApplicantID = dataGridView1.Rows[e.RowIndex].Cells["applicantID"].Value.ToString();


                txtApplicantID.Text = selectedApplicantID;


                if (e.ColumnIndex == dataGridView1.Columns["documentPath"].Index)
                {
                    string documentPath = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    if (File.Exists(documentPath))
                    {
                        try
                        {
                            Process.Start(documentPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Could not open file: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File does not exist at the specified path.");
                    }
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
           
            var lines = File.ReadAllLines(applicantPath).ToList();


            lines.RemoveAll(line => line.StartsWith(selectedApplicantID + ","));
            File.WriteAllLines(applicantPath, lines);


            dataGridView1.Rows.Clear();
            LoadDataIntoDataGridView();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            
            var lines = File.ReadAllLines(applicantPath).ToList();

            var applicantRecord = lines.FirstOrDefault(line => line.StartsWith(selectedApplicantID + ","));
            if (applicantRecord == null) return;

            var data = applicantRecord.Split(',');
            string applicantID = data[0];
            string saID = data[1];
            string firstName = data[2];
            string lastName = data[3];
            string course = data[4];

            int age = CalculateAgeFromSaID(saID);
            string gender = (saID[6] >= '0' && saID[6] <= '4') ? "Female" : "Male";


            string lastStudentNumber = GetLastStudentNumber();
            string newStudentNumber = GenerateNextStudentNumber(lastStudentNumber);


            string studentData = $"{newStudentNumber},{age},{course},{firstName},{lastName},{gender}";


            File.AppendAllText(studentsFilePath, studentData + Environment.NewLine);


            lines.Remove(applicantRecord);
            File.WriteAllLines(applicantPath, lines);

            dataGridView1.Rows.Clear();
            LoadDataIntoDataGridView();


            ///ADD applicant to student database
            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                Age = age,
                Course = course
            };


            IStudentService studentService = new StudentService();
            studentService.AddStudent(student);
        }

        private int CalculateAgeFromSaID(string saID)
        {

            string birthDateString = saID.Substring(0, 6);
            DateTime birthDate;


            if (int.TryParse(birthDateString.Substring(0, 2), out int yearPrefix))
            {
                string formattedBirthDate = (yearPrefix < 50 ? "20" : "19") + birthDateString;
                birthDate = DateTime.ParseExact(formattedBirthDate, "yyyyMMdd", CultureInfo.InvariantCulture);
            }
            else
            {
                throw new Exception("Invalid SA ID format");
            }


            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now < birthDate.AddYears(age)) age--;
            return age;
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

        private string GenerateNextStudentNumber(string lastStudentNumber)
        {
            if (string.IsNullOrEmpty(lastStudentNumber))
            {
                return "S001";
            }

            int numericPart = int.Parse(lastStudentNumber.Substring(1)) + 1;
            return "S" + numericPart.ToString("D3");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
