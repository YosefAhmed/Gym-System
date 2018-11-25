namespace GYM_Project
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
            this.search1 = new GYM_Project.search();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Yellow;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.search_btn.FlatAppearance.BorderSize = 3;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(617, 35);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(76, 33);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search ";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(478, 10);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(216, 27);
            this.search_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Member ID Or Name";
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Yellow;
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.delete_btn.FlatAppearance.BorderSize = 3;
            this.delete_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.delete_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(21, -4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(147, 45);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete Member";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search1
            // 
            this.search1.BackColor = System.Drawing.Color.Transparent;
            this.search1.Location = new System.Drawing.Point(411, 115);
            this.search1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(288, 231);
            this.search1.TabIndex = 0;
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 356);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_Form";
            this.Text = "show_all_btn";
            this.Load += new System.EventHandler(this.Search_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private search search1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
    }
}