namespace Student_Management_System
{
    partial class StudentEnrollmentEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEnrollmentEntryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YearTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdNumTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.EDPCodeTB = new System.Windows.Forms.TextBox();
            this.SubjInDGView = new System.Windows.Forms.DataGridView();
            this.EDPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEndCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EncoderTB = new System.Windows.Forms.TextBox();
            this.DTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.UnitsLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.StudPic = new Student_Management_System.CircularPictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjInDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.ExBtn);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 47);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Location = new System.Drawing.Point(12, 6);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(36, 32);
            this.BackBtn.TabIndex = 23;
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Gold;
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MinBtn.Location = new System.Drawing.Point(789, 6);
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
            this.ExBtn.Location = new System.Drawing.Point(831, 6);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(36, 32);
            this.ExBtn.TabIndex = 1;
            this.toolTip2.SetToolTip(this.ExBtn, "EXIT, the entire application.");
            this.ExBtn.UseVisualStyleBackColor = false;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TitleLbl.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Location = new System.Drawing.Point(135, 76);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(658, 47);
            this.TitleLbl.TabIndex = 24;
            this.TitleLbl.Text = "STUDENT ENROLLMENT ENTRY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 10);
            this.panel2.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.YearTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CourseTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NameTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdNumTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(192, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 169);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDENT INFORMATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Press ENTER to retrieve student\'s data.");
            // 
            // YearTB
            // 
            this.YearTB.Enabled = false;
            this.YearTB.Location = new System.Drawing.Point(293, 105);
            this.YearTB.Name = "YearTB";
            this.YearTB.Size = new System.Drawing.Size(111, 26);
            this.YearTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year";
            // 
            // CourseTB
            // 
            this.CourseTB.Enabled = false;
            this.CourseTB.Location = new System.Drawing.Point(107, 105);
            this.CourseTB.Name = "CourseTB";
            this.CourseTB.Size = new System.Drawing.Size(111, 26);
            this.CourseTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course";
            // 
            // NameTB
            // 
            this.NameTB.Enabled = false;
            this.NameTB.Location = new System.Drawing.Point(107, 65);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(243, 26);
            this.NameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // IdNumTB
            // 
            this.IdNumTB.Location = new System.Drawing.Point(107, 28);
            this.IdNumTB.MaxLength = 8;
            this.IdNumTB.Name = "IdNumTB";
            this.IdNumTB.Size = new System.Drawing.Size(169, 26);
            this.IdNumTB.TabIndex = 1;
            this.IdNumTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdNumTB_KeyPressed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "EDP Code";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(-2, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 10);
            this.panel3.TabIndex = 28;
            // 
            // EDPCodeTB
            // 
            this.EDPCodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDPCodeTB.Location = new System.Drawing.Point(110, 369);
            this.EDPCodeTB.MaxLength = 5;
            this.EDPCodeTB.Name = "EDPCodeTB";
            this.EDPCodeTB.Size = new System.Drawing.Size(169, 26);
            this.EDPCodeTB.TabIndex = 29;
            this.EDPCodeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDPCodeTB_KeyPressed);
            // 
            // SubjInDGView
            // 
            this.SubjInDGView.AllowUserToAddRows = false;
            this.SubjInDGView.AllowUserToDeleteRows = false;
            this.SubjInDGView.AllowUserToResizeColumns = false;
            this.SubjInDGView.AllowUserToResizeRows = false;
            this.SubjInDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjInDGView.ColumnHeadersHeight = 25;
            this.SubjInDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SubjInDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDPCol,
            this.Column1,
            this.TimeInCol,
            this.TimeEndCol,
            this.SchedCol,
            this.RoomCol,
            this.UnitsCol});
            this.SubjInDGView.Location = new System.Drawing.Point(16, 405);
            this.SubjInDGView.Name = "SubjInDGView";
            this.SubjInDGView.ReadOnly = true;
            this.SubjInDGView.Size = new System.Drawing.Size(851, 213);
            this.SubjInDGView.TabIndex = 30;
            this.SubjInDGView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SubjInDGView_KeyDown);
            // 
            // EDPCol
            // 
            this.EDPCol.HeaderText = "EDP Code";
            this.EDPCol.Name = "EDPCol";
            this.EDPCol.ReadOnly = true;
            this.EDPCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Subject Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TimeInCol
            // 
            this.TimeInCol.HeaderText = "Start Time";
            this.TimeInCol.Name = "TimeInCol";
            this.TimeInCol.ReadOnly = true;
            this.TimeInCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TimeEndCol
            // 
            this.TimeEndCol.HeaderText = "End Time";
            this.TimeEndCol.Name = "TimeEndCol";
            this.TimeEndCol.ReadOnly = true;
            this.TimeEndCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SchedCol
            // 
            this.SchedCol.HeaderText = "Schedule";
            this.SchedCol.Name = "SchedCol";
            this.SchedCol.ReadOnly = true;
            this.SchedCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RoomCol
            // 
            this.RoomCol.HeaderText = "Room #";
            this.RoomCol.Name = "RoomCol";
            this.RoomCol.ReadOnly = true;
            this.RoomCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UnitsCol
            // 
            this.UnitsCol.HeaderText = "Units";
            this.UnitsCol.Name = "UnitsCol";
            this.UnitsCol.ReadOnly = true;
            this.UnitsCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Red;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(450, 665);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(115, 43);
            this.CancelBtn.TabIndex = 32;
            this.CancelBtn.Text = "CANCEL";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Lime;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(329, 665);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(115, 43);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Encoded by";
            // 
            // EncoderTB
            // 
            this.EncoderTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncoderTB.Location = new System.Drawing.Point(121, 628);
            this.EncoderTB.Name = "EncoderTB";
            this.EncoderTB.Size = new System.Drawing.Size(169, 26);
            this.EncoderTB.TabIndex = 34;
            // 
            // DTimePicker
            // 
            this.DTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTimePicker.Location = new System.Drawing.Point(342, 634);
            this.DTimePicker.Name = "DTimePicker";
            this.DTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DTimePicker.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(614, 634);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Total Units";
            // 
            // UnitsLbl
            // 
            this.UnitsLbl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UnitsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsLbl.Location = new System.Drawing.Point(716, 633);
            this.UnitsLbl.Name = "UnitsLbl";
            this.UnitsLbl.Size = new System.Drawing.Size(96, 20);
            this.UnitsLbl.TabIndex = 37;
            this.UnitsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5000;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Fetching student records";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(285, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.toolTip3.SetToolTip(this.pictureBox2, "To delete added subject highlight the row you want to delete then press DELETE ke" +
        "y.");
            // 
            // toolTip3
            // 
            this.toolTip3.AutomaticDelay = 5000;
            this.toolTip3.AutoPopDelay = 50000;
            this.toolTip3.InitialDelay = 500;
            this.toolTip3.ReshowDelay = 1000;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Delete Subject Instructions";
            // 
            // StudPic
            // 
            this.StudPic.Image = ((System.Drawing.Image)(resources.GetObject("StudPic.Image")));
            this.StudPic.Location = new System.Drawing.Point(12, 52);
            this.StudPic.Name = "StudPic";
            this.StudPic.Size = new System.Drawing.Size(117, 103);
            this.StudPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StudPic.TabIndex = 23;
            this.StudPic.TabStop = false;
            // 
            // StudentEnrollmentEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(879, 720);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UnitsLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DTimePicker);
            this.Controls.Add(this.EncoderTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SubjInDGView);
            this.Controls.Add(this.EDPCodeTB);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.StudPic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentEnrollmentEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Enrollment Entry";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjInDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button ExBtn;
        private System.Windows.Forms.Button BackBtn;
        private CircularPictureBox StudPic;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdNumTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YearTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CourseTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox EDPCodeTB;
        private System.Windows.Forms.DataGridView SubjInDGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeInCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeEndCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsCol;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EncoderTB;
        private System.Windows.Forms.DateTimePicker DTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label UnitsLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}