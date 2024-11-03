using PRG282_Project.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG282_Project.Presentation_Layer
{
    public partial class ManageFrm : Form
    {
        private DatabaseHelper _dbHelper;
        private string _selectedStudentNumber;

        public ManageFrm()
        {
            InitializeComponent();
            string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageFrm_Load(object sender, EventArgs e)
        {
            _dbHelper.LoadStudentData(guna2DataGridView1);
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.White;
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text; 

            
            IStudentService studentService = new StudentService();

            try
            {
                studentService.DeleteStudent(studentNumber);
                MessageBox.Show("Student deleted successfully.");
                _dbHelper.LoadStudentData(guna2DataGridView1);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Search by StudentID")
            {
                textBox5.Text = string.Empty;
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Search by StudentID";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                _selectedStudentNumber = row.Cells["Student number"].Value.ToString();

                
                txtFirstName.Text = row.Cells["First name"].Value.ToString();
                txtLastName.Text = row.Cells["Last name"].Value.ToString();

                
                nudAge.Value = Convert.ToInt32(row.Cells["Student age"].Value);

                
                cmbCourses.SelectedItem = row.Cells["Course"].Value.ToString();

                
                string gender = row.Cells["Gender"].Value.ToString();
                if (gender == "Male")
                {
                    radio_Male.Checked = true;
                }
                else if (gender == "Female")
                {
                    radio_Female.Checked = true;
                }
            }
        }



        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedStudentNumber))
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            var updatedStudent = new Student
            {
                StudentNumber = _selectedStudentNumber,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = (int)nudAge.Value,
                Course = cmbCourses.SelectedItem.ToString(),
                Gender = radio_Male.Checked ? "Male" : "Female"
            };

            IStudentService studentService = new StudentService();

            try
            {
                
                studentService.UpdateStudent(updatedStudent);
                MessageBox.Show("Student updated successfully.");

                
                UpdateStudentInTextFile(updatedStudent);

                
                _dbHelper.LoadStudentData(guna2DataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
        }

        private void UpdateStudentInTextFile(Student updatedStudent)
        {
            string studentsFilePath = @"C:\Users\bramc\Documents\PRG282_Project\PRG282_Project\PRG282_Project\bin\Students.txt";

            
            var lines = File.ReadAllLines(studentsFilePath).ToList();

            
            var studentLineIndex = lines.FindIndex(line => line.StartsWith(updatedStudent.StudentNumber + ","));

            if (studentLineIndex != -1)
            {
                
                lines[studentLineIndex] = $"{updatedStudent.StudentNumber},{updatedStudent.Age},{updatedStudent.Course}," +
                                           $"{updatedStudent.FirstName},{updatedStudent.LastName},{updatedStudent.Gender}";

                
                File.WriteAllLines(studentsFilePath, lines);
            }
            else
            {
                MessageBox.Show("Student not found in the text file.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtStudentNumber.Text = string.Empty;


            nudAge.Value = nudAge.Minimum;


            cmbCourses.SelectedIndex = -1;


            radio_Male.Checked = false;
            radio_Female.Checked = false;


            _selectedStudentNumber = null;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            string searchStudentNumber = textBox5.Text.Trim();

            if (string.IsNullOrEmpty(searchStudentNumber))
            {
                MessageBox.Show("Please enter a student number to search.");
                return;
            }

            
            bool found = false;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
               
                if (row.Cells["Student number"].Value != null &&
                    row.Cells["Student number"].Value.ToString().Equals(searchStudentNumber, StringComparison.OrdinalIgnoreCase))
                {
                   
                    row.Selected = true;
                    guna2DataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    found = true;
                    break;
                }
            }

            
            if (!found)
            {
                MessageBox.Show("Student number not found.");
            }
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text;

            IStudentService studentService = new StudentService();

            try
            {
                // Delete from the database
                studentService.DeleteStudent(studentNumber);
                MessageBox.Show("Student deleted successfully.");

                // Delete from the text file
                string studentsFilePath = @"C:\Users\bramc\Documents\PRG282_Project\PRG282_Project\PRG282_Project\bin\Students.txt";

                var lines = File.ReadAllLines(studentsFilePath).ToList();
                var lineToDelete = lines.FirstOrDefault(line => line.StartsWith(studentNumber + ","));

                if (lineToDelete != null)
                {
                    lines.Remove(lineToDelete);
                    File.WriteAllLines(studentsFilePath, lines);
                    MessageBox.Show("Record deleted from file successfully.");
                }
                else
                {
                    MessageBox.Show("Record not found in file.");
                }

                // Refresh the DataGridView
                _dbHelper.LoadStudentData(guna2DataGridView1);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
            }
        }

        private void txtStudentNumber_Enter(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text == "Enter a student number")
            {
                txtStudentNumber.Text = string.Empty;
                txtStudentNumber.ForeColor = Color.Black;
            }
        }

        private void txtStudentNumber_Leave(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text == "Enter a student number")
            {
                txtStudentNumber.Text = string.Empty;
                txtStudentNumber.ForeColor = Color.Black;
            }
        }
    }

}
