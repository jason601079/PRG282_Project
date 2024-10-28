using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class Form1 : Form
    {
        private DatabaseHelper _dbHelper;

        public Form1()
        {
            InitializeComponent();
            string connectionString = @"Server=ANDYDEE\SQLEXPRESS;Database=Student Management System;Trusted_Connection=True;";
            _dbHelper = new DatabaseHelper(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }



       
    }
}

