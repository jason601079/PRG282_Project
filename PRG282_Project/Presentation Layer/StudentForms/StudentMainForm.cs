using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.Presentation_Layer.Student
{
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnStudentBusiness_Click(object sender, EventArgs e)
        {
            StudentBusinessCluster business = new StudentBusinessCluster();
            business.Show();
        }

        private void btnStudentProgramming_Click(object sender, EventArgs e)
        {
            StudentProgrammingCluster programming = new StudentProgrammingCluster();
            programming.Show();
        }

        private void btnStudentData_Click(object sender, EventArgs e)
        {
            StudentDataScienceCluster data = new StudentDataScienceCluster();
            data.Show();
        }

        private void btnStudentMath_Click(object sender, EventArgs e)
        {
            StudentMathematicsCluster math = new StudentMathematicsCluster();
            math.Show();
        }

        private void btnStudentNetwork_Click(object sender, EventArgs e)
        {
            StudentNetworkCluster network = new StudentNetworkCluster();
            network.Show();
        }
    }
}
