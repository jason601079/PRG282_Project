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
            string studentNumber = txtStudentNumber.Text; // Assuming you have a TextBox for student number

            // Call the business layer to delete the student
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
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                _selectedStudentNumber = row.Cells["Student number"].Value.ToString();

                // Textboxes for First Name and Last Name
                txtFirstName.Text = row.Cells["First name"].Value.ToString();
                txtLastName.Text = row.Cells["Last name"].Value.ToString();

                // NumericUpDown for Age
                nudAge.Value = Convert.ToInt32(row.Cells["Student age"].Value);

                // ComboBox for Course
                cmbCourses.SelectedItem = row.Cells["Course"].Value.ToString();

                // RadioButtons for Gender
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedStudentNumber))
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            // Collect the updated details from the form
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
                _dbHelper.LoadStudentData(guna2DataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
        }
    }
}
