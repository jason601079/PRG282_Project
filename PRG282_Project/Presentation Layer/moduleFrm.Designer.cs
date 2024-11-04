namespace PRG282_Project.Presentation_Layer
{
    partial class moduleFrm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            btn_Search = new Button();
            search_TextBox = new TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            btn_Print = new Button();
            radio_Fail = new RadioButton();
            radio_Pass = new RadioButton();
            radio_All = new RadioButton();
            label4 = new Label();
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
            panel1.Size = new Size(868, 54);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(316, 9);
            label7.Name = "label7";
            label7.Size = new Size(244, 32);
            label7.TabIndex = 3;
            label7.Text = "Module Overview";
            label7.Click += label7_Click;
            // 
            // btn_Search
            // 
            btn_Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Search.BackColor = Color.FromArgb(0, 71, 160);
            btn_Search.ForeColor = Color.WhiteSmoke;
            btn_Search.Location = new Point(763, 60);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(87, 37);
            btn_Search.TabIndex = 41;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // search_TextBox
            // 
            search_TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_TextBox.ForeColor = Color.Gray;
            search_TextBox.Location = new Point(625, 70);
            search_TextBox.Name = "search_TextBox";
            search_TextBox.Size = new Size(130, 23);
            search_TextBox.TabIndex = 40;
            search_TextBox.Text = "Search by module";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(2, 109);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(866, 392);
            guna2DataGridView1.TabIndex = 39;
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
            btn_Print.Location = new Point(769, 521);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(87, 36);
            btn_Print.TabIndex = 43;
            btn_Print.Text = "Print";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += btn_Print_Click;
            // 
            // radio_Fail
            // 
            radio_Fail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radio_Fail.AutoSize = true;
            radio_Fail.Font = new Font("Century Gothic", 9F);
            radio_Fail.ForeColor = Color.White;
            radio_Fail.Location = new Point(213, 532);
            radio_Fail.Name = "radio_Fail";
            radio_Fail.Size = new Size(46, 21);
            radio_Fail.TabIndex = 50;
            radio_Fail.TabStop = true;
            radio_Fail.Text = "Fail";
            radio_Fail.UseVisualStyleBackColor = true;
            // 
            // radio_Pass
            // 
            radio_Pass.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radio_Pass.AutoSize = true;
            radio_Pass.Font = new Font("Century Gothic", 9F);
            radio_Pass.ForeColor = Color.White;
            radio_Pass.Location = new Point(144, 532);
            radio_Pass.Name = "radio_Pass";
            radio_Pass.Size = new Size(51, 21);
            radio_Pass.TabIndex = 49;
            radio_Pass.TabStop = true;
            radio_Pass.Text = "Pass";
            radio_Pass.UseVisualStyleBackColor = true;
            // 
            // radio_All
            // 
            radio_All.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radio_All.AutoSize = true;
            radio_All.Font = new Font("Century Gothic", 9F);
            radio_All.ForeColor = Color.White;
            radio_All.Location = new Point(88, 532);
            radio_All.Name = "radio_All";
            radio_All.Size = new Size(41, 21);
            radio_All.TabIndex = 48;
            radio_All.TabStop = true;
            radio_All.Text = "All";
            radio_All.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 531);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 47;
            label4.Text = "Filter By:";
            // 
            // moduleFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 71, 200);
            ClientSize = new Size(868, 564);
            Controls.Add(radio_Fail);
            Controls.Add(radio_Pass);
            Controls.Add(radio_All);
            Controls.Add(label4);
            Controls.Add(btn_Print);
            Controls.Add(btn_Search);
            Controls.Add(search_TextBox);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel1);
            Name = "moduleFrm";
            Text = "moduleFrm";
            Load += moduleFrm_Load;
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
        private TextBox search_TextBox;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Button btn_Print;
        private RadioButton radio_Fail;
        private RadioButton radio_Pass;
        private RadioButton radio_All;
        private Label label4;
    }
}