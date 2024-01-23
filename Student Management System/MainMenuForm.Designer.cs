namespace Student_Management_System
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentPbox = new System.Windows.Forms.PictureBox();
            this.SubjPbox = new System.Windows.Forms.PictureBox();
            this.SchedPbox = new System.Windows.Forms.PictureBox();
            this.EnrPbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.ExBtn);
            this.panel1.Location = new System.Drawing.Point(-20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 47);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Gold;
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinBtn.Location = new System.Drawing.Point(806, 6);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(36, 32);
            this.MinBtn.TabIndex = 2;
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // ExBtn
            // 
            this.ExBtn.BackColor = System.Drawing.Color.Red;
            this.ExBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExBtn.BackgroundImage")));
            this.ExBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExBtn.Location = new System.Drawing.Point(848, 6);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(36, 32);
            this.ExBtn.TabIndex = 1;
            this.ExBtn.UseVisualStyleBackColor = false;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLbl.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Location = new System.Drawing.Point(243, 53);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(270, 32);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "INTERNATIONAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StudentPbox
            // 
            this.StudentPbox.Image = ((System.Drawing.Image)(resources.GetObject("StudentPbox.Image")));
            this.StudentPbox.Location = new System.Drawing.Point(232, 190);
            this.StudentPbox.Name = "StudentPbox";
            this.StudentPbox.Size = new System.Drawing.Size(100, 100);
            this.StudentPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPbox.TabIndex = 4;
            this.StudentPbox.TabStop = false;
            this.StudentPbox.Click += new System.EventHandler(this.StdEntry_Click);
            // 
            // SubjPbox
            // 
            this.SubjPbox.Image = ((System.Drawing.Image)(resources.GetObject("SubjPbox.Image")));
            this.SubjPbox.Location = new System.Drawing.Point(501, 190);
            this.SubjPbox.Name = "SubjPbox";
            this.SubjPbox.Size = new System.Drawing.Size(100, 100);
            this.SubjPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SubjPbox.TabIndex = 6;
            this.SubjPbox.TabStop = false;
            this.SubjPbox.Click += new System.EventHandler(this.SubjEntry_Click);
            // 
            // SchedPbox
            // 
            this.SchedPbox.Image = ((System.Drawing.Image)(resources.GetObject("SchedPbox.Image")));
            this.SchedPbox.Location = new System.Drawing.Point(232, 352);
            this.SchedPbox.Name = "SchedPbox";
            this.SchedPbox.Size = new System.Drawing.Size(100, 100);
            this.SchedPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SchedPbox.TabIndex = 10;
            this.SchedPbox.TabStop = false;
            this.SchedPbox.Click += new System.EventHandler(this.SubjSchedEntry_Click);
            // 
            // EnrPbox
            // 
            this.EnrPbox.Image = ((System.Drawing.Image)(resources.GetObject("EnrPbox.Image")));
            this.EnrPbox.Location = new System.Drawing.Point(501, 352);
            this.EnrPbox.Name = "EnrPbox";
            this.EnrPbox.Size = new System.Drawing.Size(100, 100);
            this.EnrPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnrPbox.TabIndex = 11;
            this.EnrPbox.TabStop = false;
            this.EnrPbox.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(243, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "STATE COLLEGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(243, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "OF THE PHILIPPINES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(243, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "ENROLLMENT MANAGER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(206, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "STUDENT FORM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(480, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "SUBJECT FORM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(210, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "SCHEDULE FORM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(454, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "ENROLLMENT FORM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(357, 40);
            this.label8.TabIndex = 19;
            this.label8.Text = "This C# Windows Form Application is made \r\nby Alvin John Araneta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(828, 486);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Dev_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(663, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "CLICK ME >>>>";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 534);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnrPbox);
            this.Controls.Add(this.SchedPbox);
            this.Controls.Add(this.SubjPbox);
            this.Controls.Add(this.StudentPbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System Main Menu";
            this.Click += new System.EventHandler(this.SubjEntry_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchedPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnrPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button ExBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox StudentPbox;
        private System.Windows.Forms.PictureBox SubjPbox;
        private System.Windows.Forms.PictureBox SchedPbox;
        private System.Windows.Forms.PictureBox EnrPbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
    }
}