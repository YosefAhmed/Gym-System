namespace GYM_Project
{
    partial class Admin_Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Year_txt = new System.Windows.Forms.TextBox();
            this.Six_M_txt = new System.Windows.Forms.TextBox();
            this.three_M_txt = new System.Windows.Forms.TextBox();
            this.one_M_txt = new System.Windows.Forms.TextBox();
            this.year_lbl = new System.Windows.Forms.Label();
            this.six_month_lbl = new System.Windows.Forms.Label();
            this.three_month_lbl = new System.Windows.Forms.Label();
            this.one_month_lbl = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Year_txt
            // 
            this.Year_txt.Location = new System.Drawing.Point(96, 119);
            this.Year_txt.Name = "Year_txt";
            this.Year_txt.Size = new System.Drawing.Size(100, 20);
            this.Year_txt.TabIndex = 0;
            // 
            // Six_M_txt
            // 
            this.Six_M_txt.Location = new System.Drawing.Point(262, 119);
            this.Six_M_txt.Name = "Six_M_txt";
            this.Six_M_txt.Size = new System.Drawing.Size(100, 20);
            this.Six_M_txt.TabIndex = 1;
            // 
            // three_M_txt
            // 
            this.three_M_txt.Location = new System.Drawing.Point(434, 119);
            this.three_M_txt.Name = "three_M_txt";
            this.three_M_txt.Size = new System.Drawing.Size(100, 20);
            this.three_M_txt.TabIndex = 2;
            // 
            // one_M_txt
            // 
            this.one_M_txt.Location = new System.Drawing.Point(605, 119);
            this.one_M_txt.Name = "one_M_txt";
            this.one_M_txt.Size = new System.Drawing.Size(100, 20);
            this.one_M_txt.TabIndex = 3;
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Location = new System.Drawing.Point(109, 86);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(70, 13);
            this.year_lbl.TabIndex = 4;
            this.year_lbl.Text = "Price Of Year";
            // 
            // six_month_lbl
            // 
            this.six_month_lbl.AutoSize = true;
            this.six_month_lbl.Location = new System.Drawing.Point(264, 86);
            this.six_month_lbl.Name = "six_month_lbl";
            this.six_month_lbl.Size = new System.Drawing.Size(92, 13);
            this.six_month_lbl.TabIndex = 5;
            this.six_month_lbl.Text = "Price Of 6 Months";
            // 
            // three_month_lbl
            // 
            this.three_month_lbl.AutoSize = true;
            this.three_month_lbl.Location = new System.Drawing.Point(439, 86);
            this.three_month_lbl.Name = "three_month_lbl";
            this.three_month_lbl.Size = new System.Drawing.Size(92, 13);
            this.three_month_lbl.TabIndex = 6;
            this.three_month_lbl.Text = "Price Of 3 Months";
            // 
            // one_month_lbl
            // 
            this.one_month_lbl.AutoSize = true;
            this.one_month_lbl.Location = new System.Drawing.Point(609, 86);
            this.one_month_lbl.Name = "one_month_lbl";
            this.one_month_lbl.Size = new System.Drawing.Size(87, 13);
            this.one_month_lbl.TabIndex = 7;
            this.one_month_lbl.Text = "Price Of 1 Month";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(346, 190);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(148, 45);
            this.Save_btn.TabIndex = 8;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Admin_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.one_month_lbl);
            this.Controls.Add(this.three_month_lbl);
            this.Controls.Add(this.six_month_lbl);
            this.Controls.Add(this.year_lbl);
            this.Controls.Add(this.one_M_txt);
            this.Controls.Add(this.three_M_txt);
            this.Controls.Add(this.Six_M_txt);
            this.Controls.Add(this.Year_txt);
            this.Name = "Admin_Settings";
            this.Size = new System.Drawing.Size(811, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Year_txt;
        private System.Windows.Forms.TextBox Six_M_txt;
        private System.Windows.Forms.TextBox three_M_txt;
        private System.Windows.Forms.TextBox one_M_txt;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Label six_month_lbl;
        private System.Windows.Forms.Label three_month_lbl;
        private System.Windows.Forms.Label one_month_lbl;
        private System.Windows.Forms.Button Save_btn;
    }
}
