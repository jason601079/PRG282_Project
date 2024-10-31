namespace PRG282_Project.Presentation_Layer
{
    partial class PrintFrm
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
            panel1 = new Panel();
            label7 = new Label();
            btn_Search = new Button();
            textBox5 = new TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_Print = new Button();
            radio_Male = new RadioButton();
            radio_All = new RadioButton();
            label4 = new Label();
            radio_Female = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 61);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(324, 10);
            label7.Name = "label7";
            label7.Size = new Size(144, 32);
            label7.TabIndex = 3;
            label7.Text = "Print/View";
            // 
            // btn_Search
            // 
            btn_Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Search.BackColor = Color.FromArgb(0, 71, 160);
            btn_Search.ForeColor = Color.WhiteSmoke;
            btn_Search.Location = new Point(769, 67);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(87, 42);
            btn_Search.TabIndex = 40;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.Location = new Point(631, 78);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(130, 22);
            textBox5.TabIndex = 39;
            textBox5.Text = "Search by Module";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 71, 160);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(0, 116);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(868, 357);
            guna2DataGridView1.TabIndex = 41;
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
            // 
            // btn_Print
            // 
            btn_Print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Print.BackColor = Color.FromArgb(0, 71, 160);
            btn_Print.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btn_Print.ForeColor = Color.White;
            btn_Print.Location = new Point(779, 523);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(77, 32);
            btn_Print.TabIndex = 42;
            btn_Print.Text = "Print";
            btn_Print.UseVisualStyleBackColor = false;
            // 
            // radio_Male
            // 
            radio_Male.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radio_Male.AutoSize = true;
            radio_Male.Font = new Font("Century Gothic", 9F);
            radio_Male.ForeColor = Color.FromArgb(0, 71, 160);
            radio_Male.Location = new Point(159, 523);
            radio_Male.Name = "radio_Male";
            radio_Male.Size = new Size(56, 21);
            radio_Male.TabIndex = 45;
            radio_Male.TabStop = true;
            radio_Male.Text = "Male";
            radio_Male.UseVisualStyleBackColor = true;
            // 
            // radio_All
            // 
            radio_All.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radio_All.AutoSize = true;
            radio_All.Font = new Font("Century Gothic", 9F);
            radio_All.ForeColor = Color.FromArgb(0, 71, 160);
            radio_All.Location = new Point(90, 523);
            radio_All.Name = "radio_All";
            radio_All.Size = new Size(41, 21);
            radio_All.TabIndex = 44;
            radio_All.TabStop = true;
            radio_All.Text = "All";
            radio_All.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(12, 523);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 43;
            label4.Text = "Gender:";
            // 
            // radio_Female
            // 
            radio_Female.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radio_Female.AutoSize = true;
            radio_Female.Font = new Font("Century Gothic", 9F);
            radio_Female.ForeColor = Color.FromArgb(0, 71, 160);
            radio_Female.Location = new Point(243, 523);
            radio_Female.Name = "radio_Female";
            radio_Female.Size = new Size(70, 21);
            radio_Female.TabIndex = 46;
            radio_Female.TabStop = true;
            radio_Female.Text = "Female";
            radio_Female.UseVisualStyleBackColor = true;
            // 
            // PrintFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(868, 564);
            Controls.Add(radio_Female);
            Controls.Add(radio_Male);
            Controls.Add(radio_All);
            Controls.Add(label4);
            Controls.Add(btn_Print);
            Controls.Add(guna2DataGridView1);
            Controls.Add(btn_Search);
            Controls.Add(textBox5);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F);
            ForeColor = Color.FromArgb(0, 71, 160);
            Name = "PrintFrm";
            Text = "PrintFrm";
            Load += PrintFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button btn_Search;
        private TextBox textBox5;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Button btn_Print;
        private RadioButton radio_Male;
        private RadioButton radio_All;
        private Label label4;
        private RadioButton radio_Female;
    }
}