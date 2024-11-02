using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PRG282_Project.Presentation_Layer
{
    public partial class DashBoardfrm : Form
    {
        private DatabaseHelper _dbHelper;
        public DashBoardfrm()
        {
            InitializeComponent();
            string connectionString = @"Server=TRENT\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);

        }
        

        private void DashBoardfrm_Load(object sender, EventArgs e)
        {
            _dbHelper.LoadTop5Achievers(dataGridView_Top5);
            _dbHelper.bcomStd(lbl_BCOM);
            _dbHelper.biStd(lbl_BI);
            _dbHelper.diplomaStd(lbl_Diploma);
            _dbHelper.PopulateDoughnutChart(chart2);
            
        }

        private void dataGridView_Top5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
