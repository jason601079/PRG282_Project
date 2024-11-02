using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace PRG282_Project.Presentation_Layer
{
    public partial class PrintFrm : Form
    {
        private DatabaseHelper _dbHelper;
        public PrintFrm()
        {
            InitializeComponent();
            string connectionString = @"Server=TRENT\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);
        }

        private void PrintFrm_Load(object sender, EventArgs e)
        {
            _dbHelper.LoadStudentData(guna2DataGridView1);
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.White;
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            
        }
    }
}
