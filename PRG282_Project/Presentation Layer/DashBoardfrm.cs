using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            //string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
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
            dataGridView_Top5.ScrollBars = ScrollBars.None;
            UpdateProgressBar();
            _dbHelper.top5FailedModules(dgvFailed);
            dgvFailed.ScrollBars = ScrollBars.None;

        }

        private void dataGridView_Top5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Percent_Click(object sender, EventArgs e)
        {

        }


        private void UpdateUI(decimal passPercentage)
        {
            // Update the progress bar's value and label
            if (passPercentage < 0) passPercentage = 0; // Ensure no negative values
            if (passPercentage > 100) passPercentage = 100; // Ensure no values exceed 100

            pBar.Value = (int)passPercentage; // Cast to int since progress bar requires an integer value
            lbl_Percent.Text = $"{passPercentage}%"; // Update label text

            // Optional: If you want to update the appearance of the progress bar based on its value
            if (passPercentage < 50)
            {
                pBar.ForeColor = Color.Red; // Example: Change color to red if below 50%
            }
            else
            {
                pBar.ForeColor = Color.White; // Change to green otherwise
            }
        }

        public void UpdateProgressBar()
        {
            // Define the connection string
            string connectionString = "Server=TRENT\\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;"; // Update with your actual connection string
            string query = @"
    SELECT 
        CAST(FLOOR((COUNT(CASE WHEN m.Pass = 1 THEN 1 END) * 100.0) / NULLIF(COUNT(*), 0) * 10) / 10 AS DECIMAL(10, 1)) AS PassPercentage
    FROM 
        dbo.Modules m;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    decimal passPercentage = (decimal)command.ExecuteScalar();

                    // Update the progress bar and label
                    UpdateUI(passPercentage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }





    }
}
