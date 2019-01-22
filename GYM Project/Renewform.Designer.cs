namespace GYM_Project
{
    partial class Renewform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renewform));
            this.confirmbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isna = new System.Windows.Forms.RadioButton();
            this.i6shr = new System.Windows.Forms.RadioButton();
            this.i3shr = new System.Windows.Forms.RadioButton();
            this.ishr = new System.Windows.Forms.RadioButton();
            this.idlbl = new System.Windows.Forms.Label();
            this.in_id = new System.Windows.Forms.Label();
            this.remin_txt = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calcbtn = new System.Windows.Forms.Button();
            this.paid_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackColor = System.Drawing.Color.Yellow;
            this.confirmbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.confirmbtn.FlatAppearance.BorderSize = 3;
            this.confirmbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.confirmbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.ForeColor = System.Drawing.Color.Black;
            this.confirmbtn.Location = new System.Drawing.Point(328, 325);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(133, 49);
            this.confirmbtn.TabIndex = 100;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.isna);
            this.groupBox1.Controls.Add(this.i6shr);
            this.groupBox1.Controls.Add(this.i3shr);
            this.groupBox1.Controls.Add(this.ishr);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.OldLace;
            this.groupBox1.Location = new System.Drawing.Point(58, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 211);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the new term";
            // 
            // isna
            // 
            this.isna.AutoSize = true;
            this.isna.ForeColor = System.Drawing.Color.OldLace;
            this.isna.Location = new System.Drawing.Point(6, 168);
            this.isna.Name = "isna";
            this.isna.Size = new System.Drawing.Size(100, 32);
            this.isna.TabIndex = 3;
            this.isna.TabStop = true;
            this.isna.Text = "1 Mear";
            this.isna.UseVisualStyleBackColor = true;
            this.isna.CheckedChanged += new System.EventHandler(this.isna_CheckedChanged);
            // 
            // i6shr
            // 
            this.i6shr.AutoSize = true;
            this.i6shr.ForeColor = System.Drawing.Color.OldLace;
            this.i6shr.Location = new System.Drawing.Point(6, 130);
            this.i6shr.Name = "i6shr";
            this.i6shr.Size = new System.Drawing.Size(124, 32);
            this.i6shr.TabIndex = 2;
            this.i6shr.TabStop = true;
            this.i6shr.Text = "6 Months";
            this.i6shr.UseVisualStyleBackColor = true;
            this.i6shr.CheckedChanged += new System.EventHandler(this.i6shr_CheckedChanged);
            // 
            // i3shr
            // 
            this.i3shr.AutoSize = true;
            this.i3shr.ForeColor = System.Drawing.Color.OldLace;
            this.i3shr.Location = new System.Drawing.Point(6, 85);
            this.i3shr.Name = "i3shr";
            this.i3shr.Size = new System.Drawing.Size(124, 32);
            this.i3shr.TabIndex = 1;
            this.i3shr.TabStop = true;
            this.i3shr.Text = "3 Months";
            this.i3shr.UseVisualStyleBackColor = true;
            this.i3shr.CheckedChanged += new System.EventHandler(this.i3shr_CheckedChanged);
            // 
            // ishr
            // 
            this.ishr.AutoSize = true;
            this.ishr.ForeColor = System.Drawing.Color.OldLace;
            this.ishr.Location = new System.Drawing.Point(6, 38);
            this.ishr.Name = "ishr";
            this.ishr.Size = new System.Drawing.Size(114, 32);
            this.ishr.TabIndex = 0;
            this.ishr.TabStop = true;
            this.ishr.Text = "1 Month";
            this.ishr.UseVisualStyleBackColor = true;
            this.ishr.CheckedChanged += new System.EventHandler(this.ishr_CheckedChanged);
            // 
            // idlbl
            // 
            this.idlbl.BackColor = System.Drawing.Color.Transparent;
            this.idlbl.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.Color.OldLace;
            this.idlbl.Location = new System.Drawing.Point(288, 21);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(58, 35);
            this.idlbl.TabIndex = 97;
            this.idlbl.Text = "ID : ";
            // 
            // in_id
            // 
            this.in_id.BackColor = System.Drawing.Color.Transparent;
            this.in_id.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_id.ForeColor = System.Drawing.Color.OldLace;
            this.in_id.Location = new System.Drawing.Point(344, 21);
            this.in_id.Name = "in_id";
            this.in_id.Size = new System.Drawing.Size(147, 35);
            this.in_id.TabIndex = 101;
            this.in_id.Text = "-";
            this.in_id.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // remin_txt
            // 
            this.remin_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remin_txt.BackColor = System.Drawing.Color.Transparent;
            this.remin_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remin_txt.ForeColor = System.Drawing.Color.OldLace;
            this.remin_txt.Location = new System.Drawing.Point(614, 200);
            this.remin_txt.Name = "remin_txt";
            this.remin_txt.Size = new System.Drawing.Size(132, 35);
            this.remin_txt.TabIndex = 108;
            this.remin_txt.Text = "-";
            this.remin_txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pricetxt
            // 
            this.pricetxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pricetxt.BackColor = System.Drawing.Color.Transparent;
            this.pricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.ForeColor = System.Drawing.Color.OldLace;
            this.pricetxt.Location = new System.Drawing.Point(614, 108);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(132, 35);
            this.pricetxt.TabIndex = 107;
            this.pricetxt.Text = "-";
            this.pricetxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 17.25F);
            this.label3.ForeColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(481, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 35);
            this.label3.TabIndex = 104;
            this.label3.Text = "Remaining:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 17.25F);
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(547, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 35);
            this.label2.TabIndex = 105;
            this.label2.Text = "Paid:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 17.25F);
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(539, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.TabIndex = 106;
            this.label1.Text = "Price: ";
            // 
            // calcbtn
            // 
            this.calcbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcbtn.BackColor = System.Drawing.Color.Yellow;
            this.calcbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcbtn.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.calcbtn.FlatAppearance.BorderSize = 3;
            this.calcbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.calcbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.calcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcbtn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcbtn.Location = new System.Drawing.Point(636, 244);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(90, 38);
            this.calcbtn.TabIndex = 103;
            this.calcbtn.Text = "Calculate";
            this.calcbtn.UseVisualStyleBackColor = false;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
            // 
            // paid_txt
            // 
            this.paid_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paid_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_txt.Location = new System.Drawing.Point(614, 160);
            this.paid_txt.Name = "paid_txt";
            this.paid_txt.Size = new System.Drawing.Size(132, 24);
            this.paid_txt.TabIndex = 102;
            this.paid_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Renewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 386);
            this.Controls.Add(this.remin_txt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.paid_txt);
            this.Controls.Add(this.in_id);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idlbl);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Renewform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renewform";
            this.Load += new System.EventHandler(this.Renewform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton isna;
        private System.Windows.Forms.RadioButton i6shr;
        private System.Windows.Forms.RadioButton i3shr;
        private System.Windows.Forms.RadioButton ishr;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label in_id;
        private System.Windows.Forms.Label remin_txt;
        private System.Windows.Forms.Label pricetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.TextBox paid_txt;
    }
}