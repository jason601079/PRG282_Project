using PRG282_Project.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class Loading_Screen : Form
    {
        private readonly IStudentService _studentService;

        public Loading_Screen(IStudentService studentService)
        {
            InitializeComponent();
            _studentService = studentService;
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            pnlProgressBar.Width += 3;

            if (pnlProgressBar.Width >= 600)
            {
                timerProgressBar.Stop();
                Home form1 = new Home();
                form1.Show();
                this.Hide();
            }
        }

        private void Loading_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
