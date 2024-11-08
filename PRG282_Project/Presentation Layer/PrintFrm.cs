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
            //string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            string connectionString = @"Server=TRENT\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);
            radio_Female.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radio_Male.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radio_All.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
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
                currentX += col.Width + 10; 
            }
            yPos += lineHeight;

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
                    return; 
                }
            }

            
            rowPrintIndex = 0;
            e.HasMorePages = false;
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text.Trim()) || textBox5.Text == "Search by Course")
            {
                MessageBox.Show("Please enter a course to search ");
            }
            else
            {
                _dbHelper.searchModule(textBox5, guna2DataGridView1);
            }
            

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                string genderFilter = null;

                
                if (radioButton == radio_Female)
                {
                    genderFilter = "Female";
                }
                else if (radioButton == radio_Male)
                {
                    genderFilter = "Male";
                }

                
                if (genderFilter != null)
                {
                    _dbHelper.LoadStudentDataFilter(guna2DataGridView1, genderFilter);
                }
                else
                {
                    _dbHelper.LoadStudentData(guna2DataGridView1); 
                }
            }
        }

    }
}
