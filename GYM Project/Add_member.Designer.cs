namespace GYM_Project
{
    partial class Add_member
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
			this.in_name = new System.Windows.Forms.TextBox();
			this.namelbl = new System.Windows.Forms.Label();
			this.idlbl = new System.Windows.Forms.Label();
			this.in_id = new System.Windows.Forms.TextBox();
			this.phlbl = new System.Windows.Forms.Label();
			this.in_pho = new System.Windows.Forms.TextBox();
			this.imonth = new System.Windows.Forms.ComboBox();
			this.iyear = new System.Windows.Forms.ComboBox();
			this.iday = new System.Windows.Forms.ComboBox();
			this.sdatelbl = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.isna = new System.Windows.Forms.RadioButton();
			this.i6shr = new System.Windows.Forms.RadioButton();
			this.i3shr = new System.Windows.Forms.RadioButton();
			this.ishr = new System.Windows.Forms.RadioButton();
			this.confirmbtn = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.exit_bar = new System.Windows.Forms.Panel();
			this.X_btn = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.exit_bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// in_name
			// 
			this.in_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.in_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.in_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.in_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(23)))), ((int)(((byte)(17)))));
			this.in_name.Location = new System.Drawing.Point(148, 47);
			this.in_name.Name = "in_name";
			this.in_name.Size = new System.Drawing.Size(258, 31);
			this.in_name.TabIndex = 0;
			// 
			// namelbl
			// 
			this.namelbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.namelbl.BackColor = System.Drawing.Color.Transparent;
			this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.namelbl.Location = new System.Drawing.Point(28, 43);
			this.namelbl.Name = "namelbl";
			this.namelbl.Size = new System.Drawing.Size(86, 35);
			this.namelbl.TabIndex = 0;
			this.namelbl.Text = "Name";
			// 
			// idlbl
			// 
			this.idlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.idlbl.BackColor = System.Drawing.Color.Transparent;
			this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.idlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.idlbl.Location = new System.Drawing.Point(51, 98);
			this.idlbl.Name = "idlbl";
			this.idlbl.Size = new System.Drawing.Size(38, 35);
			this.idlbl.TabIndex = 1;
			this.idlbl.Text = "ID";
			// 
			// in_id
			// 
			this.in_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.in_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(219)))));
			this.in_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.in_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.in_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(23)))), ((int)(((byte)(17)))));
			this.in_id.Location = new System.Drawing.Point(149, 98);
			this.in_id.Name = "in_id";
			this.in_id.ReadOnly = true;
			this.in_id.Size = new System.Drawing.Size(257, 31);
			this.in_id.TabIndex = 2;
			this.in_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.in_id.Click += new System.EventHandler(this.in_id_Click);
			// 
			// phlbl
			// 
			this.phlbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.phlbl.BackColor = System.Drawing.Color.Transparent;
			this.phlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.phlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.phlbl.Location = new System.Drawing.Point(28, 153);
			this.phlbl.Name = "phlbl";
			this.phlbl.Size = new System.Drawing.Size(83, 35);
			this.phlbl.TabIndex = 3;
			this.phlbl.Text = "Phone";
			// 
			// in_pho
			// 
			this.in_pho.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.in_pho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.in_pho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.in_pho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(23)))), ((int)(((byte)(17)))));
			this.in_pho.Location = new System.Drawing.Point(148, 153);
			this.in_pho.Name = "in_pho";
			this.in_pho.Size = new System.Drawing.Size(258, 31);
			this.in_pho.TabIndex = 4;
			// 
			// imonth
			// 
			this.imonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.imonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(219)))));
			this.imonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.imonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(23)))), ((int)(((byte)(17)))));
			this.imonth.FormattingEnabled = true;
			this.imonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.imonth.Location = new System.Drawing.Point(232, 210);
			this.imonth.Name = "imonth";
			this.imonth.Size = new System.Drawing.Size(62, 23);
			this.imonth.TabIndex = 85;
			// 
			// iyear
			// 
			this.iyear.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.iyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(219)))));
			this.iyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iyear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(23)))), ((int)(((byte)(17)))));
			this.iyear.FormattingEnabled = true;
			this.iyear.Items.AddRange(new object[] {
            "2030",
            "2029",
            "2028",
            "2027",
            "2026",
            "2025",
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017"});
			this.iyear.Location = new System.Drawing.Point(306, 210);
			this.iyear.Name = "iyear";
			this.iyear.Size = new System.Drawing.Size(66, 23);
			this.iyear.TabIndex = 86;
			// 
			// iday
			// 
			this.iday.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.iday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(219)))));
			this.iday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(23)))), ((int)(((byte)(17)))));
			this.iday.FormattingEnabled = true;
			this.iday.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
			this.iday.Location = new System.Drawing.Point(161, 210);
			this.iday.Name = "iday";
			this.iday.Size = new System.Drawing.Size(60, 23);
			this.iday.TabIndex = 87;
			// 
			// sdatelbl
			// 
			this.sdatelbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.sdatelbl.BackColor = System.Drawing.Color.Transparent;
			this.sdatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sdatelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.sdatelbl.Location = new System.Drawing.Point(16, 207);
			this.sdatelbl.Name = "sdatelbl";
			this.sdatelbl.Size = new System.Drawing.Size(122, 25);
			this.sdatelbl.TabIndex = 91;
			this.sdatelbl.Text = "Start date";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.isna);
			this.groupBox1.Controls.Add(this.i6shr);
			this.groupBox1.Controls.Add(this.i3shr);
			this.groupBox1.Controls.Add(this.ishr);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(69, 254);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(372, 45);
			this.groupBox1.TabIndex = 93;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Length";			
			// 
			// isna
			// 
			this.isna.AutoSize = true;
			this.isna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.isna.Location = new System.Drawing.Point(284, 20);
			this.isna.Name = "isna";
			this.isna.Size = new System.Drawing.Size(70, 24);
			this.isna.TabIndex = 3;
			this.isna.TabStop = true;
			this.isna.Text = "1 year";
			this.isna.UseVisualStyleBackColor = true;
			// 
			// i6shr
			// 
			this.i6shr.AutoSize = true;
			this.i6shr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.i6shr.Location = new System.Drawing.Point(186, 20);
			this.i6shr.Name = "i6shr";
			this.i6shr.Size = new System.Drawing.Size(93, 24);
			this.i6shr.TabIndex = 2;
			this.i6shr.TabStop = true;
			this.i6shr.Text = "6 months";
			this.i6shr.UseVisualStyleBackColor = true;
			// 
			// i3shr
			// 
			this.i3shr.AutoSize = true;
			this.i3shr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.i3shr.Location = new System.Drawing.Point(90, 18);
			this.i3shr.Name = "i3shr";
			this.i3shr.Size = new System.Drawing.Size(93, 24);
			this.i3shr.TabIndex = 1;
			this.i3shr.TabStop = true;
			this.i3shr.Text = "3 months";
			this.i3shr.UseVisualStyleBackColor = true;
			// 
			// ishr
			// 
			this.ishr.AutoSize = true;
			this.ishr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.ishr.Location = new System.Drawing.Point(6, 17);
			this.ishr.Name = "ishr";
			this.ishr.Size = new System.Drawing.Size(85, 24);
			this.ishr.TabIndex = 0;
			this.ishr.TabStop = true;
			this.ishr.Text = "1 month";
			this.ishr.UseVisualStyleBackColor = true;
			// 
			// confirmbtn
			// 
			this.confirmbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.confirmbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.confirmbtn.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
			this.confirmbtn.FlatAppearance.BorderSize = 0;
			this.confirmbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
			this.confirmbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.confirmbtn.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmbtn.ForeColor = System.Drawing.Color.Transparent;
			this.confirmbtn.Location = new System.Drawing.Point(189, 321);
			this.confirmbtn.Name = "confirmbtn";
			this.confirmbtn.Size = new System.Drawing.Size(105, 38);
			this.confirmbtn.TabIndex = 95;
			this.confirmbtn.Text = "Confirm";
			this.confirmbtn.UseVisualStyleBackColor = false;
			this.confirmbtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// label18
			// 
			this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.label18.Location = new System.Drawing.Point(303, 187);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(72, 22);
			this.label18.TabIndex = 90;
			this.label18.Text = "Year";
			this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label19
			// 
			this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.label19.Location = new System.Drawing.Point(240, 187);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(40, 19);
			this.label19.TabIndex = 89;
			this.label19.Text = "Mon";
			this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label20
			// 
			this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.label20.Location = new System.Drawing.Point(168, 189);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(42, 18);
			this.label20.TabIndex = 88;
			this.label20.Text = "Day";
			this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// exit_bar
			// 
			this.exit_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(50)))), ((int)(((byte)(41)))));
			this.exit_bar.Controls.Add(this.X_btn);
			this.exit_bar.Location = new System.Drawing.Point(0, 0);
			this.exit_bar.Name = "exit_bar";
			this.exit_bar.Size = new System.Drawing.Size(476, 28);
			this.exit_bar.TabIndex = 96;
			// 
			// X_btn
			// 
			this.X_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.X_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
			this.X_btn.FlatAppearance.BorderSize = 0;
			this.X_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.X_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.X_btn.ForeColor = System.Drawing.Color.White;
			this.X_btn.Location = new System.Drawing.Point(437, 0);
			this.X_btn.Name = "X_btn";
			this.X_btn.Size = new System.Drawing.Size(39, 28);
			this.X_btn.TabIndex = 8;
			this.X_btn.Text = "X";
			this.X_btn.UseVisualStyleBackColor = false;
			// 
			// Add_member
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(471, 371);
			this.Controls.Add(this.exit_bar);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.confirmbtn);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.sdatelbl);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.imonth);
			this.Controls.Add(this.iyear);
			this.Controls.Add(this.in_id);
			this.Controls.Add(this.phlbl);
			this.Controls.Add(this.in_pho);
			this.Controls.Add(this.idlbl);
			this.Controls.Add(this.namelbl);
			this.Controls.Add(this.in_name);
			this.Controls.Add(this.iday);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Add_member";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.exit_bar.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox in_name;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.TextBox in_id;
        private System.Windows.Forms.Label phlbl;
        private System.Windows.Forms.TextBox in_pho;
        private System.Windows.Forms.ComboBox imonth;
        private System.Windows.Forms.ComboBox iyear;
        private System.Windows.Forms.ComboBox iday;
        private System.Windows.Forms.Label sdatelbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ishr;
        private System.Windows.Forms.RadioButton isna;
        private System.Windows.Forms.RadioButton i6shr;
        private System.Windows.Forms.RadioButton i3shr;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Panel exit_bar;
		private System.Windows.Forms.Button X_btn;
	}
}