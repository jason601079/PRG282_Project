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
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void btn_Mng_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void Btn_Status_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

            hideSubMenu();
        }

        private void Btn_Prnt_Std_Click(object sender, EventArgs e)
        {
            //...
            //Code
            //...

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
    }
}
