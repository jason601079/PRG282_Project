namespace PRG282_Project.Presentation_Layer.Student
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel5 = new Panel();
            btnMaximise = new Button();
            btnClose = new Button();
            bnMinimise = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnMax = new Button();
            btnCloseForm = new Button();
            btnMinimize = new Button();
            label6 = new Label();
            pnlLogo = new Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            pnlLogin = new Panel();
            lblStudentClusterTitle = new Label();
            btnStudentMath = new Button();
            btnStudentNetwork = new Button();
            btnStudentData = new Button();
            btnStudentProgramming = new Button();
            btnStudentBusiness = new Button();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(17, 53, 71);
            panel5.Controls.Add(btnMaximise);
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(bnMinimise);
            panel5.Location = new Point(1520, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(87, 25);
            panel5.TabIndex = 0;
            // 
            // btnMaximise
            // 
            btnMaximise.Dock = DockStyle.Fill;
            btnMaximise.FlatStyle = FlatStyle.Flat;
            btnMaximise.Image = (Image)resources.GetObject("btnMaximise.Image");
            btnMaximise.Location = new Point(25, 0);
            btnMaximise.Name = "btnMaximise";
            btnMaximise.Size = new Size(37, 25);
            btnMaximise.TabIndex = 3;
            btnMaximise.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(62, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // bnMinimise
            // 
            bnMinimise.Dock = DockStyle.Left;
            bnMinimise.FlatStyle = FlatStyle.Flat;
            bnMinimise.Image = (Image)resources.GetObject("bnMinimise.Image");
            bnMinimise.Location = new Point(0, 0);
            bnMinimise.Name = "bnMinimise";
            bnMinimise.Size = new Size(25, 25);
            bnMinimise.TabIndex = 2;
            bnMinimise.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 53, 71);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 72);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(234, 12);
            label1.Name = "label1";
            label1.Size = new Size(461, 46);
            label1.TabIndex = 2;
            label1.Text = "CLUSTER SELECTION";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(17, 53, 71);
            panel2.Controls.Add(btnMax);
            panel2.Controls.Add(btnCloseForm);
            panel2.Controls.Add(btnMinimize);
            panel2.Location = new Point(823, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(87, 25);
            panel2.TabIndex = 1;
            // 
            // btnMax
            // 
            btnMax.Dock = DockStyle.Fill;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(25, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(37, 25);
            btnMax.TabIndex = 3;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.Dock = DockStyle.Right;
            btnCloseForm.FlatStyle = FlatStyle.Flat;
            btnCloseForm.Image = (Image)resources.GetObject("btnCloseForm.Image");
            btnCloseForm.Location = new Point(62, 0);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(25, 25);
            btnCloseForm.TabIndex = 1;
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Left;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(0, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 2;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(120, 17);
            label6.Name = "label6";
            label6.Size = new Size(93, 55);
            label6.TabIndex = 1;
            label6.Text = "BC";
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(17, 53, 71);
            pnlLogo.Controls.Add(guna2PictureBox1);
            pnlLogo.Controls.Add(label6);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(0, 72);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(317, 452);
            pnlLogo.TabIndex = 13;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(64, 94);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(200, 200);
            guna2PictureBox1.TabIndex = 3;
            guna2PictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(30, 30, 30);
            pnlLogin.Controls.Add(lblStudentClusterTitle);
            pnlLogin.Controls.Add(btnStudentMath);
            pnlLogin.Controls.Add(btnStudentNetwork);
            pnlLogin.Controls.Add(btnStudentData);
            pnlLogin.Controls.Add(btnStudentProgramming);
            pnlLogin.Controls.Add(btnStudentBusiness);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(317, 72);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(593, 452);
            pnlLogin.TabIndex = 14;
            // 
            // lblStudentClusterTitle
            // 
            lblStudentClusterTitle.AutoSize = true;
            lblStudentClusterTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentClusterTitle.ForeColor = Color.White;
            lblStudentClusterTitle.Location = new Point(59, 25);
            lblStudentClusterTitle.Name = "lblStudentClusterTitle";
            lblStudentClusterTitle.Size = new Size(494, 47);
            lblStudentClusterTitle.TabIndex = 3;
            lblStudentClusterTitle.Text = "Please Select an Option Below:";
            // 
            // btnStudentMath
            // 
            btnStudentMath.BackColor = Color.Gray;
            btnStudentMath.Location = new Point(182, 293);
            btnStudentMath.Name = "btnStudentMath";
            btnStudentMath.Size = new Size(89, 69);
            btnStudentMath.TabIndex = 2;
            btnStudentMath.Text = "Mathematics Cluster";
            btnStudentMath.UseVisualStyleBackColor = false;
            btnStudentMath.Click += btnStudentMath_Click;
            // 
            // btnStudentNetwork
            // 
            btnStudentNetwork.BackColor = Color.Gray;
            btnStudentNetwork.Location = new Point(366, 293);
            btnStudentNetwork.Name = "btnStudentNetwork";
            btnStudentNetwork.Size = new Size(89, 69);
            btnStudentNetwork.TabIndex = 1;
            btnStudentNetwork.Text = "Networking Cluster";
            btnStudentNetwork.UseVisualStyleBackColor = false;
            btnStudentNetwork.Click += btnStudentNetwork_Click;
            // 
            // btnStudentData
            // 
            btnStudentData.BackColor = Color.Gray;
            btnStudentData.Location = new Point(464, 194);
            btnStudentData.Name = "btnStudentData";
            btnStudentData.Size = new Size(89, 69);
            btnStudentData.TabIndex = 2;
            btnStudentData.Text = "Data Science Cluster";
            btnStudentData.UseVisualStyleBackColor = false;
            btnStudentData.Click += btnStudentData_Click;
            // 
            // btnStudentProgramming
            // 
            btnStudentProgramming.BackColor = Color.Gray;
            btnStudentProgramming.Location = new Point(275, 194);
            btnStudentProgramming.Name = "btnStudentProgramming";
            btnStudentProgramming.Size = new Size(89, 69);
            btnStudentProgramming.TabIndex = 1;
            btnStudentProgramming.Text = "Programming Cluster";
            btnStudentProgramming.UseVisualStyleBackColor = false;
            btnStudentProgramming.Click += btnStudentProgramming_Click;
            // 
            // btnStudentBusiness
            // 
            btnStudentBusiness.BackColor = Color.Gray;
            btnStudentBusiness.Location = new Point(88, 194);
            btnStudentBusiness.Name = "btnStudentBusiness";
            btnStudentBusiness.Size = new Size(89, 69);
            btnStudentBusiness.TabIndex = 0;
            btnStudentBusiness.Text = "Business Cluster";
            btnStudentBusiness.UseVisualStyleBackColor = false;
            btnStudentBusiness.Click += btnStudentBusiness_Click;
            // 
            // StudentMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(910, 524);
            Controls.Add(pnlLogin);
            Controls.Add(pnlLogo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentMainForm";
            Text = "StudentMainForm";
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Button btnMaximise;
        private Button btnClose;
        private Button bnMinimise;
        private Panel panel1;
        private Label label6;
        private Panel pnlLogo;
        private Panel pnlLogin;
        private Panel panel2;
        private Button btnMax;
        private Button btnCloseForm;
        private Button btnMinimize;
        private Label label1;
        private Button btnStudentData;
        private Button btnStudentProgramming;
        private Button btnStudentBusiness;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Button btnStudentMath;
        private Button btnStudentNetwork;
        private Label lblStudentClusterTitle;
    }
}