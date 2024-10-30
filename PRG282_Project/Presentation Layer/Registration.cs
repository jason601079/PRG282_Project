using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.Presentation_Layer
{
    public partial class Registration : Form
    {
        private DatabaseHelper _dbHelper;
        private StudentController _studentController;
        private IStudentService studentService;


        public Registration(IStudentService studentService)
        {
            InitializeComponent();
            string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);
            _studentController = new StudentController(studentService);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private void Registration_Load(object sender, EventArgs e)
        {

            _dbHelper.LoadStudentData(guna2DataGridView1);
            /*
             //testing purposes
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.White;
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;


           //Add colums
            guna2DataGridView1.Columns.Add("Name", "Name");
            guna2DataGridView1.Columns.Add("Surname", "Surname");
            guna2DataGridView1.Columns.Add("Age", "Age");
            guna2DataGridView1.Columns.Add("Gender", "Gender");

            //Add rows
            guna2DataGridView1.Rows.Add("Trent", "Evans","-","Male");
            guna2DataGridView1.Rows.Add("Jason", "Taylor", "-", "Male");
            */
        }
    }
}
