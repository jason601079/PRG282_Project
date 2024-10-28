namespace PRG282_Project
{
    partial class Loading_Screen
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
            components = new System.ComponentModel.Container();
            pnlStationary = new Panel();
            pnlProgressBar = new Panel();
            timerProgressBar = new System.Windows.Forms.Timer(components);
            lblLoading = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pnlStationary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlStationary
            // 
            pnlStationary.Controls.Add(pnlProgressBar);
            pnlStationary.Location = new Point(0, 330);
            pnlStationary.Name = "pnlStationary";
            pnlStationary.Size = new Size(600, 20);
            pnlStationary.TabIndex = 0;
            // 
            // pnlProgressBar
            // 
            pnlProgressBar.BackColor = Color.FromArgb(100, 210, 145);
            pnlProgressBar.Location = new Point(0, 0);
            pnlProgressBar.Name = "pnlProgressBar";
            pnlProgressBar.Size = new Size(88, 20);
            pnlProgressBar.TabIndex = 1;
            // 
            // timerProgressBar
            // 
            timerProgressBar.Enabled = true;
            timerProgressBar.Interval = 15;
            timerProgressBar.Tick += timerProgressBar_Tick;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoading.ForeColor = Color.Silver;
            lblLoading.Location = new Point(192, 149);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(180, 33);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "LOADING...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(36, 268);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 2;
            label1.Text = "Created by: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(0, 297);
            label2.Name = "label2";
            label2.Size = new Size(214, 25);
            label2.TabIndex = 3;
            label2.Text = "Jason | Trent | Calvin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Loading_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 56, 79);
            ClientSize = new Size(600, 350);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLoading);
            Controls.Add(pnlStationary);
            ForeColor = Color.FromArgb(48, 56, 79);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading_Screen";
            pnlStationary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlStationary;
        private Panel pnlProgressBar;
        private System.Windows.Forms.Timer timerProgressBar;
        private Label lblLoading;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}