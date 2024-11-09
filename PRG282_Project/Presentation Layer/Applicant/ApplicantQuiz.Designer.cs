namespace PRG282_Project.Presentation_Layer.Applicant
{
    partial class ApplicantQuiz
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label4 = new Label();
            panel1 = new Panel();
            panel_Main_Middle = new Panel();
            btnStartQuiz = new Guna.UI2.WinForms.Guna2Button();
            btnExit = new Button();
            Panel_logo = new Panel();
            label3 = new Label();
            label1 = new Label();
            Panel_Home = new Panel();
            panel1.SuspendLayout();
            panel_Main_Middle.SuspendLayout();
            Panel_logo.SuspendLayout();
            Panel_Home.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(199, 23);
            label4.Name = "label4";
            label4.Size = new Size(308, 56);
            label4.TabIndex = 1;
            label4.Text = "Bursary Quiz";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 53, 87);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 105);
            panel1.TabIndex = 0;
            // 
            // panel_Main_Middle
            // 
            panel_Main_Middle.BackColor = Color.FromArgb(30, 30, 30);
            panel_Main_Middle.Controls.Add(btnStartQuiz);
            panel_Main_Middle.Controls.Add(panel1);
            panel_Main_Middle.Location = new Point(186, 0);
            panel_Main_Middle.Name = "panel_Main_Middle";
            panel_Main_Middle.Size = new Size(708, 485);
            panel_Main_Middle.TabIndex = 4;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.CustomizableEdges = customizableEdges1;
            btnStartQuiz.DisabledState.BorderColor = Color.DarkGray;
            btnStartQuiz.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStartQuiz.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStartQuiz.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStartQuiz.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQuiz.ForeColor = Color.White;
            btnStartQuiz.Location = new Point(228, 262);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnStartQuiz.Size = new Size(250, 45);
            btnStartQuiz.TabIndex = 5;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(51, 51, 51);
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 105);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(198, 63);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 2;
            label3.Text = "Applicant Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 55);
            label1.TabIndex = 0;
            label1.Text = "BC";
            // 
            // Panel_Home
            // 
            Panel_Home.AutoScroll = true;
            Panel_Home.BackColor = Color.FromArgb(51, 51, 51);
            Panel_Home.Controls.Add(btnExit);
            Panel_Home.Controls.Add(Panel_logo);
            Panel_Home.Dock = DockStyle.Left;
            Panel_Home.Location = new Point(0, 0);
            Panel_Home.Name = "Panel_Home";
            Panel_Home.Size = new Size(198, 485);
            Panel_Home.TabIndex = 3;
            // 
            // ApplicantQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 485);
            Controls.Add(panel_Main_Middle);
            Controls.Add(Panel_Home);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApplicantQuiz";
            Text = "ApplicantQuiz";
            Load += ApplicantQuiz_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_Main_Middle.ResumeLayout(false);
            Panel_logo.ResumeLayout(false);
            Panel_logo.PerformLayout();
            Panel_Home.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Panel panel_Main_Middle;
        private Button btnExit;
        private Panel Panel_logo;
        private Label label3;
        private Label label1;
        private Panel Panel_Home;
        private Guna.UI2.WinForms.Guna2Button btnStartQuiz;
    }
}