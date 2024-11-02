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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                {
                    txtUsername.Text = "Enter username";
                    txtUsername.ForeColor = Color.Gray;
                } else
                {
                    txtUsername.ForeColor = Color.White;
                }
                
                pnlUsernameError.Visible = false;
            }
            catch { }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtPassword.Text == "")
                {
                    txtPassword.Text = "Password";
                    txtPassword.ForeColor = Color.Gray;
                } else
                {
                    txtPassword.ForeColor = Color.White;
                }
               
                pnlPassowrdError.Visible = false;

            }
            catch { }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username")
            {
                pnlUsernameError.Visible = true;
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text == "Password")
            {
                pnlPassowrdError.Visible = true;
                txtPassword.Focus();
                return;
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApplicantForm form1 = new ApplicantForm();
            form1.Show();
            this.Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximise_Click(object sender, EventArgs e)
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

        private void bnMinimise_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState= FormWindowState.Minimized;
            }
        }
    }
}
