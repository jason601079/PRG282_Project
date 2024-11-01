using PRG282_Project.Business_Logic_Layer;
using PRG282_Project.Presentation_Layer.Applicant;
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
    public partial class ApplicantForm : Form
    {
        public ApplicantForm()
        {
            InitializeComponent();
        }

        private void ApplicantForm_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main_Middle.Controls.Add(childForm);
            panel_Main_Middle.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void panel_Main_Middle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApplicantDetails_Click(object sender, EventArgs e)
        {
            openChildForm(new ApplicantDetails());
        }

       

        

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
