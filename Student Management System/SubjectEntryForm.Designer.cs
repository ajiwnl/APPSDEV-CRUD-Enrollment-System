namespace Student_Management_System
{
    partial class SubjectEntryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectEntryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CurYrTxtbox = new System.Windows.Forms.TextBox();
            this.CourseCodeCmbbox = new System.Windows.Forms.ComboBox();
            this.CatCmbbox = new System.Windows.Forms.ComboBox();
            this.OfrgCmbbox = new System.Windows.Forms.ComboBox();
            this.UnitTxtbox = new System.Windows.Forms.TextBox();
            this.DescripTxtbox = new System.Windows.Forms.TextBox();
            this.SubjCodeTxtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SubjDGView = new System.Windows.Forms.DataGridView();
            this.SubjCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjPreqCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoPreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReqSubjCodeTxtbox = new System.Windows.Forms.TextBox();
            this.CoRadBtn = new System.Windows.Forms.RadioButton();
            this.PreRadBtn = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StudPic = new Student_Management_System.CircularPictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjDGView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.CurYrTxtbox);
            this.groupBox1.Controls.Add(this.CourseCodeCmbbox);
            this.groupBox1.Controls.Add(this.CatCmbbox);
            this.groupBox1.Controls.Add(this.OfrgCmbbox);
            this.groupBox1.Controls.Add(this.UnitTxtbox);
            this.groupBox1.Controls.Add(this.DescripTxtbox);
            this.groupBox1.Controls.Add(this.SubjCodeTxtbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 294);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUBJECT INFORMATION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.toolTip3.SetToolTip(this.pictureBox2, "1 - First Semester\r\n2 - Second Semester\r\n3 - Summer");
            // 
            // CurYrTxtbox
            // 
            this.CurYrTxtbox.Location = new System.Drawing.Point(149, 244);
            this.CurYrTxtbox.Name = "CurYrTxtbox";
            this.CurYrTxtbox.Size = new System.Drawing.Size(118, 26);
            this.CurYrTxtbox.TabIndex = 14;
            // 
            // CourseCodeCmbbox
            // 
            this.CourseCodeCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseCodeCmbbox.FormattingEnabled = true;
            this.CourseCodeCmbbox.Items.AddRange(new object[] {
            "BSCpE",
            "BSCS",
            "BSIS",
            "BSIT",
            "OTHER"});
            this.CourseCodeCmbbox.Location = new System.Drawing.Point(129, 207);
            this.CourseCodeCmbbox.Name = "CourseCodeCmbbox";
            this.CourseCodeCmbbox.Size = new System.Drawing.Size(112, 28);
            this.CourseCodeCmbbox.TabIndex = 13;
            this.CourseCodeCmbbox.Tag = "";
            // 
            // CatCmbbox
            // 
            this.CatCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatCmbbox.FormattingEnabled = true;
            this.CatCmbbox.Items.AddRange(new object[] {
            "LEC",
            "LAB"});
            this.CatCmbbox.Location = new System.Drawing.Point(129, 173);
            this.CatCmbbox.Name = "CatCmbbox";
            this.CatCmbbox.Size = new System.Drawing.Size(112, 28);
            this.CatCmbbox.TabIndex = 12;
            // 
            // OfrgCmbbox
            // 
            this.OfrgCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OfrgCmbbox.FormattingEnabled = true;
            this.OfrgCmbbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.OfrgCmbbox.Location = new System.Drawing.Point(129, 136);
            this.OfrgCmbbox.Name = "OfrgCmbbox";
            this.OfrgCmbbox.Size = new System.Drawing.Size(112, 28);
            this.OfrgCmbbox.TabIndex = 11;
            // 
            // UnitTxtbox
            // 
            this.UnitTxtbox.Location = new System.Drawing.Point(129, 102);
            this.UnitTxtbox.Name = "UnitTxtbox";
            this.UnitTxtbox.Size = new System.Drawing.Size(65, 26);
            this.UnitTxtbox.TabIndex = 10;
            // 
            // DescripTxtbox
            // 
            this.DescripTxtbox.Location = new System.Drawing.Point(129, 65);
            this.DescripTxtbox.Name = "DescripTxtbox";
            this.DescripTxtbox.Size = new System.Drawing.Size(200, 26);
            this.DescripTxtbox.TabIndex = 9;
            // 
            // SubjCodeTxtbox
            // 
            this.SubjCodeTxtbox.Location = new System.Drawing.Point(129, 33);
            this.SubjCodeTxtbox.Name = "SubjCodeTxtbox";
            this.SubjCodeTxtbox.Size = new System.Drawing.Size(135, 26);
            this.SubjCodeTxtbox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Offering";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Units";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Course Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Curriculum Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.SubjDGView);
            this.groupBox2.Controls.Add(this.ReqSubjCodeTxtbox);
            this.groupBox2.Controls.Add(this.CoRadBtn);
            this.groupBox2.Controls.Add(this.PreRadBtn);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(399, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REQUISITE INFORMATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Press ENTER to retrieve or save a requisite information.");
            // 
            // SubjDGView
            // 
            this.SubjDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjCodeCol,
            this.SubjPreqCodeCol,
            this.CoPreCol});
            this.SubjDGView.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::Student_Management_System.Properties.Settings.Default, "DGReadView", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SubjDGView.Location = new System.Drawing.Point(41, 102);
            this.SubjDGView.Name = "SubjDGView";
            this.SubjDGView.ReadOnly = global::Student_Management_System.Properties.Settings.Default.DGReadView;
            this.SubjDGView.Size = new System.Drawing.Size(343, 171);
            this.SubjDGView.TabIndex = 16;
            // 
            // SubjCodeCol
            // 
            this.SubjCodeCol.HeaderText = "Subject Code";
            this.SubjCodeCol.Name = "SubjCodeCol";
            this.SubjCodeCol.ReadOnly = true;
            // 
            // SubjPreqCodeCol
            // 
            this.SubjPreqCodeCol.HeaderText = "Requisite Subject Info";
            this.SubjPreqCodeCol.Name = "SubjPreqCodeCol";
            this.SubjPreqCodeCol.ReadOnly = true;
            // 
            // CoPreCol
            // 
            this.CoPreCol.HeaderText = "Co/Pre";
            this.CoPreCol.Name = "CoPreCol";
            this.CoPreCol.ReadOnly = true;
            // 
            // ReqSubjCodeTxtbox
            // 
            this.ReqSubjCodeTxtbox.Location = new System.Drawing.Point(129, 33);
            this.ReqSubjCodeTxtbox.Name = "ReqSubjCodeTxtbox";
            this.ReqSubjCodeTxtbox.Size = new System.Drawing.Size(103, 26);
            this.ReqSubjCodeTxtbox.TabIndex = 15;
            this.ReqSubjCodeTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReqSubjCodeTxtbox_KeyPress);
            // 
            // CoRadBtn
            // 
            this.CoRadBtn.AutoSize = true;
            this.CoRadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoRadBtn.Location = new System.Drawing.Point(281, 55);
            this.CoRadBtn.Name = "CoRadBtn";
            this.CoRadBtn.Size = new System.Drawing.Size(115, 20);
            this.CoRadBtn.TabIndex = 2;
            this.CoRadBtn.TabStop = true;
            this.CoRadBtn.Text = "Co-Requisite";
            this.CoRadBtn.UseVisualStyleBackColor = true;
            // 
            // PreRadBtn
            // 
            this.PreRadBtn.AutoSize = true;
            this.PreRadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreRadBtn.Location = new System.Drawing.Point(281, 25);
            this.PreRadBtn.Name = "PreRadBtn";
            this.PreRadBtn.Size = new System.Drawing.Size(120, 20);
            this.PreRadBtn.TabIndex = 1;
            this.PreRadBtn.TabStop = true;
            this.PreRadBtn.Text = "Pre-Requisite";
            this.PreRadBtn.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Subject Code";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(261, 475);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 43);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(382, 475);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(115, 43);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.ExBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 47);
            this.panel1.TabIndex = 20;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Location = new System.Drawing.Point(13, 8);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(36, 32);
            this.BackBtn.TabIndex = 22;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Gold;
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinBtn.Location = new System.Drawing.Point(731, 8);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(36, 32);
            this.MinBtn.TabIndex = 21;
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
            this.ExBtn.Location = new System.Drawing.Point(773, 8);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(36, 32);
            this.ExBtn.TabIndex = 20;
            this.toolTip2.SetToolTip(this.ExBtn, "EXIT, the entire application.");
            this.ExBtn.UseVisualStyleBackColor = false;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TitleLbl.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Location = new System.Drawing.Point(126, 71);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(461, 61);
            this.TitleLbl.TabIndex = 21;
            this.TitleLbl.Text = "SUBJECT ENTRY";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5000;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Fetching subject records";
            // 
            // StudPic
            // 
            this.StudPic.Image = ((System.Drawing.Image)(resources.GetObject("StudPic.Image")));
            this.StudPic.Location = new System.Drawing.Point(10, 53);
            this.StudPic.Name = "StudPic";
            this.StudPic.Size = new System.Drawing.Size(110, 96);
            this.StudPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StudPic.TabIndex = 22;
            this.StudPic.TabStop = false;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 5000;
            this.toolTip2.AutoPopDelay = 50000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 1000;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip2.ToolTipTitle = "EXIT Warning!";
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 5000;
            this.toolTip3.AutoPopDelay = 50000;
            this.toolTip3.InitialDelay = 500;
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ReshowDelay = 1000;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Offering Checkbox Value";
            // 
            // SubjectEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 546);
            this.Controls.Add(this.StudPic);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SubjectEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subject Entry";
            this.Load += new System.EventHandler(this.SubjectEntryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjDGView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CurYrTxtbox;
        private System.Windows.Forms.ComboBox CourseCodeCmbbox;
        private System.Windows.Forms.ComboBox CatCmbbox;
        private System.Windows.Forms.ComboBox OfrgCmbbox;
        private System.Windows.Forms.TextBox UnitTxtbox;
        private System.Windows.Forms.TextBox DescripTxtbox;
        private System.Windows.Forms.TextBox SubjCodeTxtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView SubjDGView;
        private System.Windows.Forms.TextBox ReqSubjCodeTxtbox;
        private System.Windows.Forms.RadioButton CoRadBtn;
        private System.Windows.Forms.RadioButton PreRadBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button ExBtn;
        private System.Windows.Forms.Label TitleLbl;
        private CircularPictureBox StudPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjPreqCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoPreCol;
    }
}