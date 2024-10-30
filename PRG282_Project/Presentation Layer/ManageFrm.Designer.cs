﻿namespace PRG282_Project.Presentation_Layer
{
    partial class ManageFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            btn_Update = new Button();
            btnClear = new Button();
            label6 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtStudentNumber = new TextBox();
            label1 = new Label();
            btn_Delete = new Button();
            btn_Search = new Button();
            textBox5 = new TextBox();
            cmbCourses = new ComboBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            nudAge = new NumericUpDown();
            groupBox1 = new GroupBox();
            radio_Female = new RadioButton();
            radio_Male = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(2, 111);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(866, 226);
            guna2DataGridView1.TabIndex = 1;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = SystemColors.Control;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            guna2DataGridView1.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 54);
            panel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(269, 9);
            label7.Name = "label7";
            label7.Size = new Size(323, 32);
            label7.TabIndex = 3;
            label7.Text = "Manage Student details";
            // 
            // btn_Update
            // 
            btn_Update.Anchor = AnchorStyles.Bottom;
            btn_Update.BackColor = Color.FromArgb(0, 71, 160);
            btn_Update.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(387, 516);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(95, 40);
            btn_Update.TabIndex = 35;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom;
            btnClear.BackColor = Color.FromArgb(0, 71, 160);
            btnClear.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(250, 516);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 40);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(275, 411);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 30;
            label6.Text = "Course:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(509, 362);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 25;
            label4.Text = "Gender:";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Bottom;
            txtLastName.Location = new Point(387, 358);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(104, 23);
            txtLastName.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(266, 362);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 21;
            label2.Text = "Last Name:";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Anchor = AnchorStyles.Bottom;
            txtStudentNumber.Location = new Point(518, 487);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(101, 23);
            txtStudentNumber.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(21, 362);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 19;
            label1.Text = "First Name:";
            // 
            // btn_Delete
            // 
            btn_Delete.Anchor = AnchorStyles.Bottom;
            btn_Delete.BackColor = Color.FromArgb(0, 71, 160);
            btn_Delete.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(527, 516);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(92, 40);
            btn_Delete.TabIndex = 36;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Search
            // 
            btn_Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Search.BackColor = Color.FromArgb(0, 71, 160);
            btn_Search.ForeColor = Color.WhiteSmoke;
            btn_Search.Location = new Point(763, 62);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(87, 37);
            btn_Search.TabIndex = 38;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.Location = new Point(625, 72);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(130, 23);
            textBox5.TabIndex = 37;
            textBox5.Text = "Search by StudentID";
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // cmbCourses
            // 
            cmbCourses.Anchor = AnchorStyles.Bottom;
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Items.AddRange(new object[] { "BI", "BCOMP", "DIPLOMA" });
            cmbCourses.Location = new Point(387, 407);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(104, 23);
            cmbCourses.TabIndex = 39;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Bottom;
            txtFirstName.Location = new Point(141, 362);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(104, 23);
            txtFirstName.TabIndex = 40;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(21, 408);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 42;
            label3.Text = "Age:";
            // 
            // nudAge
            // 
            nudAge.Location = new Point(141, 408);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(101, 23);
            nudAge.TabIndex = 41;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_Female);
            groupBox1.Controls.Add(radio_Male);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(605, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(110, 93);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            // 
            // radio_Female
            // 
            radio_Female.Anchor = AnchorStyles.Bottom;
            radio_Female.AutoSize = true;
            radio_Female.ForeColor = Color.Black;
            radio_Female.Location = new Point(20, 54);
            radio_Female.Name = "radio_Female";
            radio_Female.Size = new Size(78, 25);
            radio_Female.TabIndex = 10;
            radio_Female.TabStop = true;
            radio_Female.Text = "Female";
            radio_Female.UseVisualStyleBackColor = true;
            // 
            // radio_Male
            // 
            radio_Male.Anchor = AnchorStyles.Bottom;
            radio_Male.AutoSize = true;
            radio_Male.ForeColor = Color.Black;
            radio_Male.Location = new Point(20, 23);
            radio_Male.Name = "radio_Male";
            radio_Male.Size = new Size(62, 25);
            radio_Male.TabIndex = 9;
            radio_Male.TabStop = true;
            radio_Male.Text = "Male";
            radio_Male.UseVisualStyleBackColor = true;
            // 
            // ManageFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 564);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(nudAge);
            Controls.Add(txtFirstName);
            Controls.Add(cmbCourses);
            Controls.Add(btn_Search);
            Controls.Add(textBox5);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btnClear);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtStudentNumber);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(guna2DataGridView1);
            Name = "ManageFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageFrm";
            Load += ManageFrm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Panel panel1;
        private Label label7;
        private Button btn_Update;
        private Button btnClear;
        private Label label6;
        private Label label4;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtStudentNumber;
        private Label label1;
        private Button btn_Delete;
        private Button btn_Search;
        private TextBox textBox5;
        private ComboBox cmbCourses;
        private TextBox txtFirstName;
        private Label label3;
        private NumericUpDown nudAge;
        private GroupBox groupBox1;
        private RadioButton radio_Female;
        private RadioButton radio_Male;
    }
}