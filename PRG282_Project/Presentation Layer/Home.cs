using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PRG282_Project.Presentation_Layer
{
    public partial class Home : Form
    {
        private IStudentService studentService;
        public Home()
        {
            InitializeComponent();
            customeDesign();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void customeDesign()
        {
            panel_Student.Visible = false;
            Panel_Course.Visible = false;
            Panel_Score.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_Student.Visible == true)
                panel_Student.Visible = false;

            if (Panel_Course.Visible == true)
                Panel_Course.Visible = false;

            if (Panel_Score.Visible == true)
                Panel_Score.Visible = false;

        }


        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }


        private void Btn_Student_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Student);
        }


        private void Btn_reg_Click(object sender, EventArgs e)
        {

            openChildForm(new Registration(studentService));

            hideSubMenu();
        }

        private void btn_Mng_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageFrm());

            hideSubMenu();
        }



        private void Btn_Prnt_Std_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintFrm());

            hideSubMenu();
        }

        private void Btn_Course_Click(object sender, EventArgs e)
        {
            showSubmenu(Panel_Course);
        }

        private void Btn_NewCOurse_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void Btn_ManageCourse_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void Btn_PrintCourse_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void Btn_Score_Click(object sender, EventArgs e)
        {
            showSubmenu(Panel_Score);
        }

        private void Btn_NewScore_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void Btn_ManageScore_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void Btn_PrntScore_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //show subform in main form
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
