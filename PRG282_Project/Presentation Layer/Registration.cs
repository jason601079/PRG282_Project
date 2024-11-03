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
using TheArtOfDevHtmlRenderer.Adapters;
using static PRG282_Project.IStudentService;

namespace PRG282_Project.Presentation_Layer
{
    public partial class Registration : Form
    {
        private DatabaseHelper _dbHelper;

        private IStudentService studentService;


        public Registration(IStudentService studentService)
        {
            InitializeComponent();
            string connectionString = @"Server=TRENT\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

           
            string gender = radio_Male.Checked ? "Male" : radio_Female.Checked ? "Female" : null;

           
            int age = (int)nudAge.Value;

            
            string course = cmbCourse.SelectedItem?.ToString();

            
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
            _dbHelper.LoadStudentData(guna2DataGridView1);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private void Registration_Load(object sender, EventArgs e)
        {

            _dbHelper.LoadStudentData(guna2DataGridView1);

            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.White;
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;


       

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
