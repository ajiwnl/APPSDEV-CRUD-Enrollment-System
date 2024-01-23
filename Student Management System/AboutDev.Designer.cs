namespace Student_Management_System
{
    partial class AboutDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDev));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FB = new System.Windows.Forms.PictureBox();
            this.IG = new System.Windows.Forms.PictureBox();
            this.YT = new System.Windows.Forms.PictureBox();
            this.circularPictureBox1 = new Student_Management_System.CircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ExBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // ExBtn
            // 
            this.ExBtn.BackColor = System.Drawing.Color.Red;
            this.ExBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExBtn.BackgroundImage")));
            this.ExBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExBtn.Location = new System.Drawing.Point(248, 9);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(36, 32);
            this.ExBtn.TabIndex = 3;
            this.ExBtn.UseVisualStyleBackColor = false;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "<About the Dev/>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(5, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 126);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FB
            // 
            this.FB.Image = ((System.Drawing.Image)(resources.GetObject("FB.Image")));
            this.FB.Location = new System.Drawing.Point(32, 410);
            this.FB.Name = "FB";
            this.FB.Size = new System.Drawing.Size(38, 30);
            this.FB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FB.TabIndex = 4;
            this.FB.TabStop = false;
            this.FB.Click += new System.EventHandler(this.FB_Click);
            // 
            // IG
            // 
            this.IG.Image = ((System.Drawing.Image)(resources.GetObject("IG.Image")));
            this.IG.Location = new System.Drawing.Point(110, 410);
            this.IG.Name = "IG";
            this.IG.Size = new System.Drawing.Size(38, 30);
            this.IG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IG.TabIndex = 5;
            this.IG.TabStop = false;
            this.IG.Click += new System.EventHandler(this.IG_Click);
            // 
            // YT
            // 
            this.YT.Image = ((System.Drawing.Image)(resources.GetObject("YT.Image")));
            this.YT.Location = new System.Drawing.Point(191, 410);
            this.YT.Name = "YT";
            this.YT.Size = new System.Drawing.Size(38, 30);
            this.YT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YT.TabIndex = 6;
            this.YT.TabStop = false;
            this.YT.Click += new System.EventHandler(this.YT_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(72, 100);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(132, 124);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 1;
            this.circularPictureBox1.TabStop = false;
            // 
            // AboutDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(295, 495);
            this.Controls.Add(this.YT);
            this.Controls.Add(this.IG);
            this.Controls.Add(this.FB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About the Dev";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExBtn;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox FB;
        private System.Windows.Forms.PictureBox IG;
        private System.Windows.Forms.PictureBox YT;
    }
}