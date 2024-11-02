namespace PRG282_Project.Presentation_Layer
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Panel_Home = new Panel();
            btnExit = new Button();
            btnDashboard = new Button();
            Panel_Course = new Panel();
            Btn_PrintCourse = new Button();
            Btn_ManageCourse = new Button();
            Btn_NewCOurse = new Button();
            Btn_Course = new Button();
            panel_Student = new Panel();
            Btn_Prnt_Std = new Button();
            btn_Mng = new Button();
            Btn_reg = new Button();
            Btn_Student = new Button();
            Panel_logo = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel_Main_Middle = new Panel();
            panel_cover = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            Panel_Home.SuspendLayout();
            Panel_Course.SuspendLayout();
            panel_Student.SuspendLayout();
            Panel_logo.SuspendLayout();
            panel_Main_Middle.SuspendLayout();
            panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_Home
            // 
            Panel_Home.AutoScroll = true;
            Panel_Home.BackColor = Color.FromArgb(0, 71, 160);
            Panel_Home.Controls.Add(btnExit);
            Panel_Home.Controls.Add(btnDashboard);
            Panel_Home.Controls.Add(Panel_Course);
            Panel_Home.Controls.Add(Btn_Course);
            Panel_Home.Controls.Add(panel_Student);
            Panel_Home.Controls.Add(Btn_Student);
            Panel_Home.Controls.Add(Panel_logo);
            Panel_Home.Dock = DockStyle.Left;
            Panel_Home.Location = new Point(0, 0);
            Panel_Home.Name = "Panel_Home";
            Panel_Home.Size = new Size(198, 596);
            Panel_Home.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 556);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(181, 63);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 12F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 493);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(181, 63);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // Panel_Course
            // 
            Panel_Course.BackColor = Color.FromArgb(0, 71, 200);
            Panel_Course.Controls.Add(Btn_PrintCourse);
            Panel_Course.Controls.Add(Btn_ManageCourse);
            Panel_Course.Controls.Add(Btn_NewCOurse);
            Panel_Course.Dock = DockStyle.Top;
            Panel_Course.Location = new Point(0, 369);
            Panel_Course.Name = "Panel_Course";
            Panel_Course.Size = new Size(181, 124);
            Panel_Course.TabIndex = 4;
            Panel_Course.Paint += panel1_Paint;
            // 
            // Btn_PrintCourse
            // 
            Btn_PrintCourse.Dock = DockStyle.Top;
            Btn_PrintCourse.FlatAppearance.BorderSize = 0;
            Btn_PrintCourse.FlatStyle = FlatStyle.Flat;
            Btn_PrintCourse.Font = new Font("Century Gothic", 12F);
            Btn_PrintCourse.ForeColor = Color.White;
            Btn_PrintCourse.Location = new Point(0, 80);
            Btn_PrintCourse.Name = "Btn_PrintCourse";
            Btn_PrintCourse.Padding = new Padding(35, 0, 0, 0);
            Btn_PrintCourse.Size = new Size(181, 40);
            Btn_PrintCourse.TabIndex = 3;
            Btn_PrintCourse.Text = "Print";
            Btn_PrintCourse.TextAlign = ContentAlignment.MiddleLeft;
            Btn_PrintCourse.UseVisualStyleBackColor = true;
            Btn_PrintCourse.Click += Btn_PrintCourse_Click;
            // 
            // Btn_ManageCourse
            // 
            Btn_ManageCourse.Dock = DockStyle.Top;
            Btn_ManageCourse.FlatAppearance.BorderSize = 0;
            Btn_ManageCourse.FlatStyle = FlatStyle.Flat;
            Btn_ManageCourse.Font = new Font("Century Gothic", 12F);
            Btn_ManageCourse.ForeColor = Color.White;
            Btn_ManageCourse.Location = new Point(0, 40);
            Btn_ManageCourse.Name = "Btn_ManageCourse";
            Btn_ManageCourse.Padding = new Padding(35, 0, 0, 0);
            Btn_ManageCourse.Size = new Size(181, 40);
            Btn_ManageCourse.TabIndex = 1;
            Btn_ManageCourse.Text = "Manage Course";
            Btn_ManageCourse.TextAlign = ContentAlignment.MiddleLeft;
            Btn_ManageCourse.UseVisualStyleBackColor = true;
            Btn_ManageCourse.Click += Btn_ManageCourse_Click;
            // 
            // Btn_NewCOurse
            // 
            Btn_NewCOurse.Dock = DockStyle.Top;
            Btn_NewCOurse.FlatAppearance.BorderSize = 0;
            Btn_NewCOurse.FlatStyle = FlatStyle.Flat;
            Btn_NewCOurse.Font = new Font("Century Gothic", 12F);
            Btn_NewCOurse.ForeColor = Color.White;
            Btn_NewCOurse.Location = new Point(0, 0);
            Btn_NewCOurse.Name = "Btn_NewCOurse";
            Btn_NewCOurse.Padding = new Padding(35, 0, 0, 0);
            Btn_NewCOurse.Size = new Size(181, 40);
            Btn_NewCOurse.TabIndex = 0;
            Btn_NewCOurse.Text = "New Course";
            Btn_NewCOurse.TextAlign = ContentAlignment.MiddleLeft;
            Btn_NewCOurse.UseVisualStyleBackColor = true;
            Btn_NewCOurse.Click += Btn_NewCOurse_Click;
            // 
            // Btn_Course
            // 
            Btn_Course.Dock = DockStyle.Top;
            Btn_Course.FlatAppearance.BorderSize = 0;
            Btn_Course.FlatStyle = FlatStyle.Flat;
            Btn_Course.Font = new Font("Century Gothic", 12F);
            Btn_Course.ForeColor = Color.White;
            Btn_Course.Location = new Point(0, 306);
            Btn_Course.Name = "Btn_Course";
            Btn_Course.Padding = new Padding(10, 0, 0, 0);
            Btn_Course.Size = new Size(181, 63);
            Btn_Course.TabIndex = 3;
            Btn_Course.Text = "Course";
            Btn_Course.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Course.UseVisualStyleBackColor = true;
            Btn_Course.Click += Btn_Course_Click;
            // 
            // panel_Student
            // 
            panel_Student.BackColor = Color.FromArgb(0, 71, 200);
            panel_Student.Controls.Add(Btn_Prnt_Std);
            panel_Student.Controls.Add(btn_Mng);
            panel_Student.Controls.Add(Btn_reg);
            panel_Student.Dock = DockStyle.Top;
            panel_Student.Location = new Point(0, 186);
            panel_Student.Name = "panel_Student";
            panel_Student.Size = new Size(181, 120);
            panel_Student.TabIndex = 2;
            // 
            // Btn_Prnt_Std
            // 
            Btn_Prnt_Std.Dock = DockStyle.Top;
            Btn_Prnt_Std.FlatAppearance.BorderSize = 0;
            Btn_Prnt_Std.FlatStyle = FlatStyle.Flat;
            Btn_Prnt_Std.Font = new Font("Century Gothic", 12F);
            Btn_Prnt_Std.ForeColor = Color.White;
            Btn_Prnt_Std.Location = new Point(0, 80);
            Btn_Prnt_Std.Name = "Btn_Prnt_Std";
            Btn_Prnt_Std.Padding = new Padding(35, 0, 0, 0);
            Btn_Prnt_Std.Size = new Size(181, 40);
            Btn_Prnt_Std.TabIndex = 3;
            Btn_Prnt_Std.Text = "Print";
            Btn_Prnt_Std.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Prnt_Std.UseVisualStyleBackColor = true;
            Btn_Prnt_Std.Click += Btn_Prnt_Std_Click;
            // 
            // btn_Mng
            // 
            btn_Mng.Dock = DockStyle.Top;
            btn_Mng.FlatAppearance.BorderSize = 0;
            btn_Mng.FlatStyle = FlatStyle.Flat;
            btn_Mng.Font = new Font("Century Gothic", 12F);
            btn_Mng.ForeColor = Color.White;
            btn_Mng.Location = new Point(0, 40);
            btn_Mng.Name = "btn_Mng";
            btn_Mng.Padding = new Padding(35, 0, 0, 0);
            btn_Mng.Size = new Size(181, 40);
            btn_Mng.TabIndex = 1;
            btn_Mng.Text = "Manage Student";
            btn_Mng.TextAlign = ContentAlignment.MiddleLeft;
            btn_Mng.UseVisualStyleBackColor = true;
            btn_Mng.Click += btn_Mng_Click;
            // 
            // Btn_reg
            // 
            Btn_reg.Dock = DockStyle.Top;
            Btn_reg.FlatAppearance.BorderSize = 0;
            Btn_reg.FlatStyle = FlatStyle.Flat;
            Btn_reg.Font = new Font("Century Gothic", 12F);
            Btn_reg.ForeColor = Color.White;
            Btn_reg.Location = new Point(0, 0);
            Btn_reg.Name = "Btn_reg";
            Btn_reg.Padding = new Padding(35, 0, 0, 0);
            Btn_reg.Size = new Size(181, 40);
            Btn_reg.TabIndex = 0;
            Btn_reg.Text = "Registration";
            Btn_reg.TextAlign = ContentAlignment.MiddleLeft;
            Btn_reg.UseVisualStyleBackColor = true;
            Btn_reg.Click += Btn_reg_Click;
            // 
            // Btn_Student
            // 
            Btn_Student.Dock = DockStyle.Top;
            Btn_Student.FlatAppearance.BorderSize = 0;
            Btn_Student.FlatStyle = FlatStyle.Flat;
            Btn_Student.Font = new Font("Century Gothic", 12F);
            Btn_Student.ForeColor = Color.White;
            Btn_Student.Location = new Point(0, 123);
            Btn_Student.Name = "Btn_Student";
            Btn_Student.Padding = new Padding(10, 0, 0, 0);
            Btn_Student.Size = new Size(181, 63);
            Btn_Student.TabIndex = 1;
            Btn_Student.Text = "Student";
            Btn_Student.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Student.UseVisualStyleBackColor = true;
            Btn_Student.Click += Btn_Student_Click;
            // 
            // Panel_logo
            // 
            Panel_logo.Controls.Add(label3);
            Panel_logo.Controls.Add(label2);
            Panel_logo.Controls.Add(label1);
            Panel_logo.Dock = DockStyle.Top;
            Panel_logo.Location = new Point(0, 0);
            Panel_logo.Name = "Panel_logo";
            Panel_logo.Size = new Size(181, 123);
            Panel_logo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1, 55);
            label3.Name = "label3";
            label3.Size = new Size(177, 19);
            label3.TabIndex = 2;
            label3.Text = "Student Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 74);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 1;
            label2.Text = "System";
            label2.Click += label2_Click;
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
            panel_Main_Middle.Controls.Add(panel_cover);
            panel_Main_Middle.Dock = DockStyle.Fill;
            panel_Main_Middle.Location = new Point(198, 0);
            panel_Main_Middle.Name = "panel_Main_Middle";
            panel_Main_Middle.Size = new Size(857, 596);
            panel_Main_Middle.TabIndex = 1;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(pictureBox1);
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(857, 596);
            panel_cover.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(0, 71, 160);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(854, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 509);
            panel3.Name = "panel3";
            panel3.Size = new Size(857, 87);
            panel3.TabIndex = 2;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(114, 49);
            label11.Name = "label11";
            label11.Size = new Size(71, 21);
            label11.TabIndex = 3;
            label11.Text = "Female:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(30, 49);
            label10.Name = "label10";
            label10.Size = new Size(53, 21);
            label10.TabIndex = 2;
            label10.Text = "Male:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 13);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 1;
            label5.Text = "Total Students:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 82);
            panel2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(123, 53);
            label9.Name = "label9";
            label9.Size = new Size(62, 21);
            label9.TabIndex = 5;
            label9.Text = "Admin";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(123, 19);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 4;
            label8.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(57, 53);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 2;
            label6.Text = "Role:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 19);
            label7.Name = "label7";
            label7.Size = new Size(87, 21);
            label7.TabIndex = 3;
            label7.Text = "Welcome:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 55);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(411, 25);
            label4.TabIndex = 0;
            label4.Text = "Belgium Campus ITversity, Stellenbosch";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 596);
            Controls.Add(panel_Main_Middle);
            Controls.Add(Panel_Home);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Page";
            Load += Home_Load;
            Panel_Home.ResumeLayout(false);
            Panel_Course.ResumeLayout(false);
            panel_Student.ResumeLayout(false);
            Panel_logo.ResumeLayout(false);
            Panel_logo.PerformLayout();
            panel_Main_Middle.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Home;
        private Panel panel_Student;
        private Button Btn_Student;
        private Panel Panel_logo;
        private Button Btn_Prnt_Std;
        private Button btn_Mng;
        private Button Btn_reg;
        private Panel Panel_Course;
        private Button Btn_PrintCourse;
        private Button Btn_ManageCourse;
        private Button Btn_NewCOurse;
        private Button Btn_Course;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel_Main_Middle;
        private Panel panel_cover;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label11;
        private Label label10;
        private Button btnExit;
        private Button btnDashboard;
    }
}