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
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.imonth = new System.Windows.Forms.ComboBox();
            this.iyear = new System.Windows.Forms.ComboBox();
            this.iday = new System.Windows.Forms.ComboBox();
            this.sdatelbl = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isna = new System.Windows.Forms.RadioButton();
            this.i6shr = new System.Windows.Forms.RadioButton();
            this.i3shr = new System.Windows.Forms.RadioButton();
            this.ishr = new System.Windows.Forms.RadioButton();
            this.calcbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // in_name
            // 
            this.in_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_name.Location = new System.Drawing.Point(146, 33);
            this.in_name.Multiline = true;
            this.in_name.Name = "in_name";
            this.in_name.Size = new System.Drawing.Size(258, 35);
            this.in_name.TabIndex = 0;
            // 
            // namelbl
            // 
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(24, 33);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(105, 35);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name : ";
            // 
            // idlbl
            // 
            this.idlbl.BackColor = System.Drawing.Color.Transparent;
            this.idlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(61, 91);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(60, 35);
            this.idlbl.TabIndex = 1;
            this.idlbl.Text = "ID : ";
            // 
            // in_id
            // 
            this.in_id.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.in_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_id.Location = new System.Drawing.Point(147, 91);
            this.in_id.Multiline = true;
            this.in_id.Name = "in_id";
            this.in_id.ReadOnly = true;
            this.in_id.Size = new System.Drawing.Size(257, 35);
            this.in_id.TabIndex = 2;
            this.in_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.in_id.Click += new System.EventHandler(this.in_id_Click);
            // 
            // phlbl
            // 
            this.phlbl.BackColor = System.Drawing.Color.Transparent;
            this.phlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phlbl.Location = new System.Drawing.Point(24, 145);
            this.phlbl.Name = "phlbl";
            this.phlbl.Size = new System.Drawing.Size(114, 35);
            this.phlbl.TabIndex = 3;
            this.phlbl.Text = "Phone : ";
            // 
            // in_pho
            // 
            this.in_pho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_pho.Location = new System.Drawing.Point(145, 145);
            this.in_pho.Multiline = true;
            this.in_pho.Name = "in_pho";
            this.in_pho.Size = new System.Drawing.Size(258, 35);
            this.in_pho.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(323, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 22);
            this.label18.TabIndex = 90;
            this.label18.Text = "Year";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(245, 201);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 22);
            this.label19.TabIndex = 89;
            this.label19.Text = "Mon";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(166, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 22);
            this.label20.TabIndex = 88;
            this.label20.Text = "Day";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imonth
            // 
            this.imonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imonth.ForeColor = System.Drawing.Color.Black;
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
            this.imonth.Location = new System.Drawing.Point(248, 201);
            this.imonth.Name = "imonth";
            this.imonth.Size = new System.Drawing.Size(62, 23);
            this.imonth.TabIndex = 85;
            this.imonth.Click += new System.EventHandler(this.imonth_Click);
            // 
            // iyear
            // 
            this.iyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iyear.ForeColor = System.Drawing.Color.Black;
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
            this.iyear.Location = new System.Drawing.Point(323, 200);
            this.iyear.Name = "iyear";
            this.iyear.Size = new System.Drawing.Size(66, 23);
            this.iyear.TabIndex = 86;
            this.iyear.Click += new System.EventHandler(this.iyear_Click);
            // 
            // iday
            // 
            this.iday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iday.ForeColor = System.Drawing.Color.Black;
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
            this.iday.Location = new System.Drawing.Point(166, 201);
            this.iday.Name = "iday";
            this.iday.Size = new System.Drawing.Size(60, 23);
            this.iday.TabIndex = 87;
            this.iday.Click += new System.EventHandler(this.iday_Click);
            // 
            // sdatelbl
            // 
            this.sdatelbl.BackColor = System.Drawing.Color.Transparent;
            this.sdatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdatelbl.Location = new System.Drawing.Point(20, 194);
            this.sdatelbl.Name = "sdatelbl";
            this.sdatelbl.Size = new System.Drawing.Size(148, 35);
            this.sdatelbl.TabIndex = 91;
            this.sdatelbl.Text = "Start date : ";
            // 
            // pricetxt
            // 
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(640, 12);
            this.pricetxt.Multiline = true;
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(143, 35);
            this.pricetxt.TabIndex = 92;
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.isna);
            this.groupBox1.Controls.Add(this.i6shr);
            this.groupBox1.Controls.Add(this.i3shr);
            this.groupBox1.Controls.Add(this.ishr);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 164);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Length";
            // 
            // isna
            // 
            this.isna.AutoSize = true;
            this.isna.ForeColor = System.Drawing.Color.White;
            this.isna.Location = new System.Drawing.Point(6, 128);
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
            this.i6shr.ForeColor = System.Drawing.Color.White;
            this.i6shr.Location = new System.Drawing.Point(6, 98);
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
            this.i3shr.ForeColor = System.Drawing.Color.White;
            this.i3shr.Location = new System.Drawing.Point(6, 68);
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
            this.ishr.ForeColor = System.Drawing.Color.White;
            this.ishr.Location = new System.Drawing.Point(6, 38);
            this.ishr.Name = "ishr";
            this.ishr.Size = new System.Drawing.Size(85, 24);
            this.ishr.TabIndex = 0;
            this.ishr.TabStop = true;
            this.ishr.Text = "1 month";
            this.ishr.UseVisualStyleBackColor = true;
            this.ishr.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // calcbtn
            // 
            this.calcbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcbtn.Location = new System.Drawing.Point(670, 53);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(90, 38);
            this.calcbtn.TabIndex = 94;
            this.calcbtn.Text = "Calculate";
            this.calcbtn.UseVisualStyleBackColor = true;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(353, 381);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(105, 38);
            this.confirmbtn.TabIndex = 95;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GYM_Project.Properties.Resources.fitness1;
            this.ClientSize = new System.Drawing.Size(795, 456);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.sdatelbl);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.imonth);
            this.Controls.Add(this.iyear);
            this.Controls.Add(this.iday);
            this.Controls.Add(this.in_id);
            this.Controls.Add(this.phlbl);
            this.Controls.Add(this.in_pho);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.in_name);
            this.Name = "Add_member";
            this.Text = "Add_member";
            this.Load += new System.EventHandler(this.Add_member_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox imonth;
        private System.Windows.Forms.ComboBox iyear;
        private System.Windows.Forms.ComboBox iday;
        private System.Windows.Forms.Label sdatelbl;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ishr;
        private System.Windows.Forms.RadioButton isna;
        private System.Windows.Forms.RadioButton i6shr;
        private System.Windows.Forms.RadioButton i3shr;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.Button confirmbtn;
    }
}