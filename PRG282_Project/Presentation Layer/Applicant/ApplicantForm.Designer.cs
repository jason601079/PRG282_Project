namespace PRG282_Project.Presentation_Layer
{
    partial class ApplicantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel_Home = new Panel();
            btnExit = new Button();
            btnApplicantDetails = new Button();
            Panel_logo = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel_Main_Middle = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            Panel_Home.SuspendLayout();
            Panel_logo.SuspendLayout();
            panel_Main_Middle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Home
            // 
            Panel_Home.AutoScroll = true;
            Panel_Home.BackColor = Color.FromArgb(51, 51, 51);
            Panel_Home.Controls.Add(btnExit);
            Panel_Home.Controls.Add(btnApplicantDetails);
            Panel_Home.Controls.Add(Panel_logo);
            Panel_Home.Dock = DockStyle.Left;
            Panel_Home.Location = new Point(0, 0);
            Panel_Home.Name = "Panel_Home";
            Panel_Home.Size = new Size(198, 400);
            Panel_Home.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(51, 51, 51);
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 168);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(198, 63);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnApplicantDetails
            // 
            btnApplicantDetails.BackColor = Color.FromArgb(51, 51, 51);
            btnApplicantDetails.Dock = DockStyle.Top;
            btnApplicantDetails.FlatAppearance.BorderSize = 0;
            btnApplicantDetails.FlatStyle = FlatStyle.Flat;
            btnApplicantDetails.Font = new Font("Century Gothic", 12F);
            btnApplicantDetails.ForeColor = Color.White;
            btnApplicantDetails.Location = new Point(0, 105);
            btnApplicantDetails.Name = "btnApplicantDetails";
            btnApplicantDetails.Padding = new Padding(10, 0, 0, 0);
            btnApplicantDetails.Size = new Size(198, 63);
            btnApplicantDetails.TabIndex = 1;
            btnApplicantDetails.Text = "Applicant Details";
            btnApplicantDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnApplicantDetails.UseVisualStyleBackColor = false;
            btnApplicantDetails.Click += btnApplicantDetails_Click;
            // 
            // Panel_logo
            // 
            Panel_logo.BackColor = Color.FromArgb(29, 53, 87);
            Panel_logo.Controls.Add(label3);
            Panel_logo.Controls.Add(label1);
            Panel_logo.Dock = DockStyle.Top;
            Panel_logo.Location = new Point(0, 0);
            Panel_logo.Name = "Panel_logo";
            Panel_logo.Size = new Size(198, 105);
            Panel_logo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 2;
            label3.Text = "Applicant Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 55);
            label1.TabIndex = 0;
            label1.Text = "BC";
            // 
            // panel_Main_Middle
            // 
            panel_Main_Middle.Controls.Add(panel1);
            panel_Main_Middle.Location = new Point(198, 0);
            panel_Main_Middle.Name = "panel_Main_Middle";
            panel_Main_Middle.Size = new Size(520, 400);
            panel_Main_Middle.TabIndex = 2;
            panel_Main_Middle.Paint += panel_Main_Middle_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 53, 87);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 55);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 21);
            label4.Name = "label4";
            label4.Size = new Size(470, 28);
            label4.TabIndex = 1;
            label4.Text = "Belgium Campus ITversity, Stellenbosch";
            // 
            // ApplicantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 400);
            Controls.Add(panel_Main_Middle);
            Controls.Add(Panel_Home);
            Name = "ApplicantForm";
            Text = "ApplicantForm";
            Load += ApplicantForm_Load;
            Panel_Home.ResumeLayout(false);
            Panel_logo.ResumeLayout(false);
            Panel_logo.PerformLayout();
            panel_Main_Middle.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Home;
        private Button btnExit;
        private Button btnApplicantDetails;
        private Panel Panel_logo;
        private Label label3;
        private Label label1;
        private Panel panel_Main_Middle;
        private Panel panel1;
        private Label label4;
    }
}