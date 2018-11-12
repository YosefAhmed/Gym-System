namespace GYM_Project
{
    partial class All_Members
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
            this.search_name_btn = new System.Windows.Forms.Button();
            this.search_id_btn = new System.Windows.Forms.Button();
            this.search_lbl = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // search_name_btn
            // 
            this.search_name_btn.Location = new System.Drawing.Point(348, 40);
            this.search_name_btn.Name = "search_name_btn";
            this.search_name_btn.Size = new System.Drawing.Size(119, 25);
            this.search_name_btn.TabIndex = 10;
            this.search_name_btn.Text = "search with Name";
            this.search_name_btn.UseVisualStyleBackColor = true;
            // 
            // search_id_btn
            // 
            this.search_id_btn.Location = new System.Drawing.Point(238, 40);
            this.search_id_btn.Name = "search_id_btn";
            this.search_id_btn.Size = new System.Drawing.Size(104, 25);
            this.search_id_btn.TabIndex = 9;
            this.search_id_btn.Text = "search with id";
            this.search_id_btn.UseVisualStyleBackColor = true;
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Location = new System.Drawing.Point(92, 15);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(145, 13);
            this.search_lbl.TabIndex = 8;
            this.search_lbl.Text = "Enter ID Or Name You Wont ";
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(243, 12);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(224, 20);
            this.search_txt.TabIndex = 7;
            // 
            // All_Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 354);
            this.Controls.Add(this.search_name_btn);
            this.Controls.Add(this.search_id_btn);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_txt);
            this.Name = "All_Members";
            this.Text = "All_Members";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_name_btn;
        private System.Windows.Forms.Button search_id_btn;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.TextBox search_txt;
    }
}