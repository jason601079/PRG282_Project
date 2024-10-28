namespace PRG282_Project
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tbpTable = new TabPage();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            btnSortByCourse = new Button();
            btnSortAge = new Button();
            dataGridView1 = new DataGridView();
            tbp = new TabPage();
            button1 = new Button();
            btnValidateForm = new Button();
            rtxtModules = new RichTextBox();
            groupBox1 = new GroupBox();
            rbtnDiploma = new RadioButton();
            rbtnBI = new RadioButton();
            rbtnBCOMP = new RadioButton();
            nudAge = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            txtStudentname = new TextBox();
            tbpDelete = new TabPage();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            txtDeleteStudentNumber = new TextBox();
            tbpEditStudent = new TabPage();
            button5 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            tabControl1.SuspendLayout();
            tbpTable.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tbp.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            tbpDelete.SuspendLayout();
            tbpEditStudent.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 62);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbpTable);
            tabControl1.Controls.Add(tbp);
            tabControl1.Controls.Add(tbpDelete);
            tabControl1.Controls.Add(tbpEditStudent);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(24, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 373);
            tabControl1.TabIndex = 2;
            // 
            // tbpTable
            // 
            tbpTable.Controls.Add(panel2);
            tbpTable.Controls.Add(dataGridView1);
            tbpTable.Location = new Point(4, 30);
            tbpTable.Name = "tbpTable";
            tbpTable.Padding = new Padding(3);
            tbpTable.Size = new Size(744, 339);
            tbpTable.TabIndex = 0;
            tbpTable.Text = "Student Records";
            tbpTable.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnSortByCourse);
            panel2.Controls.Add(btnSortAge);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 274);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 62);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(635, 3);
            button4.Name = "button4";
            button4.Size = new Size(100, 56);
            button4.TabIndex = 3;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(420, 3);
            button3.Name = "button3";
            button3.Size = new Size(100, 56);
            button3.TabIndex = 2;
            button3.Text = "Sort By Names ASC";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSortByCourse
            // 
            btnSortByCourse.Location = new Point(228, 3);
            btnSortByCourse.Name = "btnSortByCourse";
            btnSortByCourse.Size = new Size(100, 56);
            btnSortByCourse.TabIndex = 1;
            btnSortByCourse.Text = "Sort by Course";
            btnSortByCourse.UseVisualStyleBackColor = true;
            // 
            // btnSortAge
            // 
            btnSortAge.Location = new Point(3, 3);
            btnSortAge.Name = "btnSortAge";
            btnSortAge.Size = new Size(100, 56);
            btnSortAge.TabIndex = 0;
            btnSortAge.Text = "Sort by age";
            btnSortAge.UseVisualStyleBackColor = true;
            btnSortAge.Click += btnSortAge_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(748, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tbp
            // 
            tbp.Controls.Add(button1);
            tbp.Controls.Add(btnValidateForm);
            tbp.Controls.Add(rtxtModules);
            tbp.Controls.Add(groupBox1);
            tbp.Controls.Add(nudAge);
            tbp.Controls.Add(label2);
            tbp.Controls.Add(label1);
            tbp.Controls.Add(txtStudentname);
            tbp.Location = new Point(4, 30);
            tbp.Name = "tbp";
            tbp.Padding = new Padding(3);
            tbp.Size = new Size(744, 339);
            tbp.TabIndex = 1;
            tbp.Text = "Add Student";
            tbp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(595, 298);
            button1.Name = "button1";
            button1.Size = new Size(134, 41);
            button1.TabIndex = 7;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnValidateForm
            // 
            btnValidateForm.BackColor = Color.DodgerBlue;
            btnValidateForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidateForm.ForeColor = Color.White;
            btnValidateForm.Location = new Point(455, 298);
            btnValidateForm.Name = "btnValidateForm";
            btnValidateForm.Size = new Size(134, 41);
            btnValidateForm.TabIndex = 6;
            btnValidateForm.Text = "Validate Form";
            btnValidateForm.UseVisualStyleBackColor = false;
            btnValidateForm.Click += btnValidateForm_Click;
            // 
            // rtxtModules
            // 
            rtxtModules.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtModules.Location = new Point(487, 29);
            rtxtModules.Name = "rtxtModules";
            rtxtModules.Size = new Size(242, 231);
            rtxtModules.TabIndex = 5;
            rtxtModules.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnDiploma);
            groupBox1.Controls.Add(rbtnBI);
            groupBox1.Controls.Add(rbtnBCOMP);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(99, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 134);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose a course :";
            // 
            // rbtnDiploma
            // 
            rbtnDiploma.AutoSize = true;
            rbtnDiploma.Location = new Point(32, 90);
            rbtnDiploma.Name = "rbtnDiploma";
            rbtnDiploma.Size = new Size(95, 25);
            rbtnDiploma.TabIndex = 2;
            rbtnDiploma.TabStop = true;
            rbtnDiploma.Text = "DIPLOMA";
            rbtnDiploma.UseVisualStyleBackColor = true;
            rbtnDiploma.Click += rbtnDiploma_Click;
            // 
            // rbtnBI
            // 
            rbtnBI.AutoSize = true;
            rbtnBI.Location = new Point(32, 59);
            rbtnBI.Name = "rbtnBI";
            rbtnBI.Size = new Size(41, 25);
            rbtnBI.TabIndex = 1;
            rbtnBI.TabStop = true;
            rbtnBI.Text = "BI";
            rbtnBI.UseVisualStyleBackColor = true;
            rbtnBI.Click += rbtnBI_Click;
            // 
            // rbtnBCOMP
            // 
            rbtnBCOMP.AutoSize = true;
            rbtnBCOMP.Location = new Point(32, 28);
            rbtnBCOMP.Name = "rbtnBCOMP";
            rbtnBCOMP.Size = new Size(82, 25);
            rbtnBCOMP.TabIndex = 0;
            rbtnBCOMP.TabStop = true;
            rbtnBCOMP.Text = "BCOMP";
            rbtnBCOMP.UseVisualStyleBackColor = true;
            rbtnBCOMP.Click += rbtnBCOMP_Click;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(182, 75);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(120, 29);
            nudAge.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 77);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 2;
            label2.Text = "Student age :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 1;
            label1.Text = "Student Fullname :";
            // 
            // txtStudentname
            // 
            txtStudentname.Location = new Point(182, 31);
            txtStudentname.Name = "txtStudentname";
            txtStudentname.Size = new Size(271, 29);
            txtStudentname.TabIndex = 0;
            // 
            // tbpDelete
            // 
            tbpDelete.Controls.Add(button2);
            tbpDelete.Controls.Add(richTextBox1);
            tbpDelete.Controls.Add(label3);
            tbpDelete.Controls.Add(txtDeleteStudentNumber);
            tbpDelete.Location = new Point(4, 30);
            tbpDelete.Name = "tbpDelete";
            tbpDelete.Padding = new Padding(3);
            tbpDelete.Size = new Size(744, 339);
            tbpDelete.TabIndex = 2;
            tbpDelete.Text = "Delete Student";
            tbpDelete.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(175, 105);
            button2.Name = "button2";
            button2.Size = new Size(134, 41);
            button2.TabIndex = 7;
            button2.Text = "Delete Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(485, 18);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(242, 315);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "Student details will pop up here once a student number is enetered";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 37);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 2;
            label3.Text = "Student number :";
            // 
            // txtDeleteStudentNumber
            // 
            txtDeleteStudentNumber.Location = new Point(188, 34);
            txtDeleteStudentNumber.Name = "txtDeleteStudentNumber";
            txtDeleteStudentNumber.Size = new Size(271, 29);
            txtDeleteStudentNumber.TabIndex = 1;
            // 
            // tbpEditStudent
            // 
            tbpEditStudent.Controls.Add(button5);
            tbpEditStudent.Controls.Add(label4);
            tbpEditStudent.Controls.Add(textBox3);
            tbpEditStudent.Location = new Point(4, 30);
            tbpEditStudent.Name = "tbpEditStudent";
            tbpEditStudent.Padding = new Padding(3);
            tbpEditStudent.Size = new Size(744, 339);
            tbpEditStudent.TabIndex = 3;
            tbpEditStudent.Text = "Edit Student Detials";
            tbpEditStudent.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.DodgerBlue;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(237, 58);
            button5.Name = "button5";
            button5.Size = new Size(134, 41);
            button5.TabIndex = 8;
            button5.Text = "Search Student";
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 16);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 4;
            label4.Text = "Student number :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 29);
            textBox3.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 470);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tbpTable.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tbp.ResumeLayout(false);
            tbp.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            tbpDelete.ResumeLayout(false);
            tbpDelete.PerformLayout();
            tbpEditStudent.ResumeLayout(false);
            tbpEditStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tbpTable;
        private DataGridView dataGridView1;
        private TabPage tbp;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button btnSortByCourse;
        private Button btnSortAge;
        private Label label1;
        private TextBox txtStudentname;
        private GroupBox groupBox1;
        private RadioButton rbtnDiploma;
        private RadioButton rbtnBI;
        private RadioButton rbtnBCOMP;
        private NumericUpDown nudAge;
        private Label label2;
        private Button btnValidateForm;
        private RichTextBox rtxtModules;
        private Button button1;
        private TabPage tbpDelete;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox txtDeleteStudentNumber;
        private Button button2;
        private TabPage tbpEditStudent;
        private Button button5;
        private Label label4;
        private TextBox textBox3;
    }
}
