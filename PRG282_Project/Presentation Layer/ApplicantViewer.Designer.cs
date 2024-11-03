namespace PRG282_Project.Presentation_Layer
{
    partial class ApplicantViewer
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantViewer));
            panel1 = new Panel();
            label7 = new Label();
            dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            txtApplicantID = new Guna.UI2.WinForms.Guna2TextBox();
            btnReject = new Button();
            btnAccept = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
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
            label7.Location = new Point(358, 9);
            label7.Name = "label7";
            label7.Size = new Size(153, 32);
            label7.TabIndex = 3;
            label7.Text = "Applicants";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(0, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(868, 224);
            dataGridView1.TabIndex = 2;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView1.ThemeStyle.BackColor = SystemColors.Control;
            dataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            dataGridView1.ThemeStyle.ReadOnly = false;
            dataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dataGridView1.ThemeStyle.RowsStyle.Height = 25;
            dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtApplicantID);
            panel2.Controls.Add(btnReject);
            panel2.Controls.Add(btnAccept);
            panel2.Location = new Point(2, 335);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 188);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 14);
            label1.Name = "label1";
            label1.Size = new Size(308, 24);
            label1.TabIndex = 3;
            label1.Text = "Selected Applicant (applicantID)";
            // 
            // txtApplicantID
            // 
            txtApplicantID.CustomizableEdges = customizableEdges1;
            txtApplicantID.DefaultText = "";
            txtApplicantID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtApplicantID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtApplicantID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtApplicantID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtApplicantID.Enabled = false;
            txtApplicantID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApplicantID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtApplicantID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtApplicantID.Location = new Point(375, 44);
            txtApplicantID.Margin = new Padding(6);
            txtApplicantID.Name = "txtApplicantID";
            txtApplicantID.PasswordChar = '\0';
            txtApplicantID.PlaceholderText = "";
            txtApplicantID.SelectedText = "";
            txtApplicantID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtApplicantID.Size = new Size(57, 56);
            txtApplicantID.TabIndex = 2;
            // 
            // btnReject
            // 
            btnReject.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReject.Image = (Image)resources.GetObject("btnReject.Image");
            btnReject.ImageAlign = ContentAlignment.MiddleLeft;
            btnReject.Location = new Point(507, 115);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(119, 48);
            btnReject.TabIndex = 1;
            btnReject.Text = "REJECT";
            btnReject.TextAlign = ContentAlignment.MiddleRight;
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnAccept
            // 
            btnAccept.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccept.Location = new Point(176, 115);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(119, 48);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "ACCEPT";
            btnAccept.TextAlign = ContentAlignment.MiddleRight;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // ApplicantViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(868, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "ApplicantViewer";
            Text = "ApplicantViewer";
            Load += ApplicantViewer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Panel panel2;
        private Button btnAccept;
        private Button btnReject;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtApplicantID;
    }
}