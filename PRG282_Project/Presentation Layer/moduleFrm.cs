using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.Presentation_Layer
{
    public partial class moduleFrm : Form
    {
        private DatabaseHelper _dbHelper;
        public moduleFrm()
        {
            InitializeComponent();
            //string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            string connectionString = @"Server=TRENT\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);
            radio_All.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radio_Fail.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radio_Pass.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void moduleFrm_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.DefaultCellStyle.BackColor = Color.White;
            guna2DataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            guna2DataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            guna2DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            _dbHelper.loadDataModules(guna2DataGridView1);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDoc
            };
            printPreviewDialog.ShowDialog();
        }
        private int rowPrintIndex = 0; // Track the index of row being printed
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
           
            Font font = new Font("Arial", 10);
            int startX = 100;
            int startY = 100;
            int yPos = startY;
            int lineHeight = font.Height + 10;

            // Print headers
            int currentX = startX;
            foreach (DataGridViewColumn col in guna2DataGridView1.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, font, Brushes.Black, new PointF(currentX, yPos));
                currentX += col.Width + 10; // Adjust for next column based on width
            }
            yPos += lineHeight; // Move down for rows

            // Print rows
            while (rowPrintIndex < guna2DataGridView1.Rows.Count)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[rowPrintIndex];
                currentX = startX;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellValue = cell.Value?.ToString() ?? string.Empty;
                    e.Graphics.DrawString(cellValue, font, Brushes.Black, new PointF(currentX, yPos));
                    currentX += cell.OwningColumn.Width + 10;
                }

                yPos += lineHeight;
                rowPrintIndex++;

                // Check if the page is full and needs to continue on the next page
                if (yPos + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return; // Exit the method to print on the next page
                }
            }

            // Reset index if all rows are printed
            rowPrintIndex = 0;
            e.HasMorePages = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(search_TextBox.Text) || search_TextBox.Text == "Search by module")
            {
                MessageBox.Show("Please enter a module to search for");
            }
            else
            {
                _dbHelper.searchModule2(search_TextBox, guna2DataGridView1);
            }

            
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the current radio button is checked before filtering
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                string choice = null;

                // Determine which radio button is checked
                if (radioButton == radio_Pass)
                {
                    choice = "Pass";
                }
                else if (radioButton == radio_Fail)
                {
                    choice = "Fail";
                }

                // Load filtered data based on the selected gender, or load all if "All" is selected
                if (choice != null)
                {
                    _dbHelper.LoadFilteredDataModules(guna2DataGridView1, choice);
                }
                else
                {
                    _dbHelper.loadDataModules(guna2DataGridView1); // Load all data if "All" is selected
                }
            }
        }

    }
}
