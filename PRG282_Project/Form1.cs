using PRG282_Project.Presentation_Layer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PRG282_Project
{
    public partial class frmMain : Form
    {
        private DatabaseHelper _dbHelper;
        
        private IStudentService studentService;


        public frmMain(IStudentService studentService)
        {
            InitializeComponent();
            string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dbHelper.LoadStudentData(dataGridView1);
        }

        private void rbtnBCOMP_Click(object sender, EventArgs e)
        {
            rtxtModules.Clear();
            rtxtModules.Text = @"Modules enrolled for BCOMP :

WPR281
LPR281
MAT281
STAT281
PRG281
PRG282                                
PMM281                              
SWT281           
DBD281
";
        }

        private void rbtnBI_Click(object sender, EventArgs e)
        {
            rtxtModules.Clear();
            rtxtModules.Text = @"Modules enrolled for BI :

LPR271
MAT271
STAT271
PMM271
SAD271
";

        }

        private void rbtnDiploma_Click(object sender, EventArgs e)
        {
            rtxtModules.Clear();
            rtxtModules.Text = @"Modules enrolled for DIPLOMA :

WPR271
PRG271
MAT271
STAT271
SWT271
";
        }

        private void btnSortAge_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidateForm_Click(object sender, EventArgs e)
        {
            // Retrieve the student name from the TextBox
            string studentName = txtStudentname.Text.Trim();

            // Retrieve the student age from the NumericUpDown control
            int studentAge = (int)nudAge.Value;

            // Determine the selected course
            string course = "";
            if (rbtnBCOMP.Checked)
            {
                course = "BCOMP";
            }
            else if (rbtnBI.Checked)
            {
                course = "BI";
            }
            else if (rbtnDiploma.Checked)
            {
                course = "DIPLOMA";
            }

            // Use the service to add the student
           




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

