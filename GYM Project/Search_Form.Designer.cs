﻿namespace GYM_Project
{
    partial class Search_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Form));
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.allusers_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.endedusers_btn = new System.Windows.Forms.Button();
            this.conusers_btn = new System.Windows.Forms.Button();
            this.search1 = new GYM_Project.search();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.BackColor = System.Drawing.Color.Yellow;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.search_btn.FlatAppearance.BorderSize = 3;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(1162, 34);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(76, 33);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search ";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(1023, 9);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(216, 27);
            this.search_txt.TabIndex = 2;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            this.search_txt.Enter += new System.EventHandler(this.search_txt_Enter);
            this.search_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_txt_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(825, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Member ID Or Name";
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.BackColor = System.Drawing.Color.Yellow;
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.delete_btn.FlatAppearance.BorderSize = 3;
            this.delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(1023, 350);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(147, 45);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete Member";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // allusers_btn
            // 
            this.allusers_btn.BackColor = System.Drawing.Color.Yellow;
            this.allusers_btn.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.allusers_btn.FlatAppearance.BorderSize = 3;
            this.allusers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.allusers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.allusers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allusers_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.allusers_btn.Location = new System.Drawing.Point(12, 9);
            this.allusers_btn.Name = "allusers_btn";
            this.allusers_btn.Size = new System.Drawing.Size(172, 48);
            this.allusers_btn.TabIndex = 86;
            this.allusers_btn.Text = "All Members";
            this.allusers_btn.UseVisualStyleBackColor = false;
            this.allusers_btn.Click += new System.EventHandler(this.allusers_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Location = new System.Drawing.Point(16, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 26);
            this.panel2.TabIndex = 82;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(267, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 27);
            this.button3.TabIndex = 88;
            this.button3.Text = "Phone";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(761, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 27);
            this.button2.TabIndex = 84;
            this.button2.Text = "Count";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(699, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 27);
            this.button1.TabIndex = 83;
            this.button1.Text = "invite";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(628, -1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 27);
            this.button9.TabIndex = 82;
            this.button9.Text = "Freeze";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(538, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 27);
            this.button10.TabIndex = 83;
            this.button10.Text = "End_Date";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(446, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 27);
            this.button11.TabIndex = 84;
            this.button11.Text = "Start_Date";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(377, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 27);
            this.button12.TabIndex = 85;
            this.button12.Text = "Term";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(55, -1);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(211, 27);
            this.button13.TabIndex = 86;
            this.button13.Text = "Name";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(0, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 27);
            this.button14.TabIndex = 87;
            this.button14.Text = "ID";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(840, 348);
            this.flowLayoutPanel1.TabIndex = 85;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // endedusers_btn
            // 
            this.endedusers_btn.BackColor = System.Drawing.Color.Yellow;
            this.endedusers_btn.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.endedusers_btn.FlatAppearance.BorderSize = 3;
            this.endedusers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.endedusers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.endedusers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endedusers_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.endedusers_btn.Location = new System.Drawing.Point(12, 114);
            this.endedusers_btn.Name = "endedusers_btn";
            this.endedusers_btn.Size = new System.Drawing.Size(172, 48);
            this.endedusers_btn.TabIndex = 84;
            this.endedusers_btn.Text = "Ended Members";
            this.endedusers_btn.UseVisualStyleBackColor = false;
            this.endedusers_btn.Click += new System.EventHandler(this.endedusers_btn_Click);
            // 
            // conusers_btn
            // 
            this.conusers_btn.BackColor = System.Drawing.Color.Yellow;
            this.conusers_btn.FlatAppearance.BorderColor = System.Drawing.Color.OldLace;
            this.conusers_btn.FlatAppearance.BorderSize = 3;
            this.conusers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.conusers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.conusers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conusers_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.conusers_btn.Location = new System.Drawing.Point(12, 63);
            this.conusers_btn.Name = "conusers_btn";
            this.conusers_btn.Size = new System.Drawing.Size(172, 48);
            this.conusers_btn.TabIndex = 83;
            this.conusers_btn.Text = "UnExpired Members";
            this.conusers_btn.UseVisualStyleBackColor = false;
            this.conusers_btn.Click += new System.EventHandler(this.conusers_btn_Click);
            // 
            // search1
            // 
            this.search1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search1.BackColor = System.Drawing.Color.Transparent;
            this.search1.Location = new System.Drawing.Point(944, 114);
            this.search1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(288, 231);
            this.search1.TabIndex = 0;
            this.search1.Load += new System.EventHandler(this.search1_Load);
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 595);
            this.Controls.Add(this.allusers_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.endedusers_btn);
            this.Controls.Add(this.conusers_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "show_all_btn";
            this.Load += new System.EventHandler(this.Search_Form_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private search search1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button allusers_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button endedusers_btn;
        private System.Windows.Forms.Button conusers_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}