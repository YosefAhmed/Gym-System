namespace GYM_Project
{
    partial class Form1
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
            this.new_btn = new System.Windows.Forms.Button();
            this.member_btn = new System.Windows.Forms.Button();
            this.renew_btn = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.search_id_btn = new System.Windows.Forms.Button();
            this.search_name_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(57, 134);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(192, 118);
            this.new_btn.TabIndex = 0;
            this.new_btn.Text = "New Member";
            this.new_btn.UseVisualStyleBackColor = true;
            // 
            // member_btn
            // 
            this.member_btn.Location = new System.Drawing.Point(314, 134);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(192, 118);
            this.member_btn.TabIndex = 1;
            this.member_btn.Text = "Member";
            this.member_btn.UseVisualStyleBackColor = true;
            // 
            // renew_btn
            // 
            this.renew_btn.Location = new System.Drawing.Point(568, 134);
            this.renew_btn.Name = "renew_btn";
            this.renew_btn.Size = new System.Drawing.Size(192, 118);
            this.renew_btn.TabIndex = 2;
            this.renew_btn.Text = "Renew";
            this.renew_btn.UseVisualStyleBackColor = true;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(298, 12);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(224, 20);
            this.search_txt.TabIndex = 3;
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.Location = new System.Drawing.Point(147, 15);
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(145, 13);
            this.search_lbl.TabIndex = 4;
            this.search_lbl.Text = "Enter ID Or Name You Wont ";
            // 
            // search_id_btn
            // 
            this.search_id_btn.Location = new System.Drawing.Point(293, 40);
            this.search_id_btn.Name = "search_id_btn";
            this.search_id_btn.Size = new System.Drawing.Size(104, 25);
            this.search_id_btn.TabIndex = 5;
            this.search_id_btn.Text = "search with id";
            this.search_id_btn.UseVisualStyleBackColor = true;
            // 
            // search_name_btn
            // 
            this.search_name_btn.Location = new System.Drawing.Point(403, 40);
            this.search_name_btn.Name = "search_name_btn";
            this.search_name_btn.Size = new System.Drawing.Size(119, 25);
            this.search_name_btn.TabIndex = 6;
            this.search_name_btn.Text = "search with Name";
            this.search_name_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 430);
            this.Controls.Add(this.search_name_btn);
            this.Controls.Add(this.search_id_btn);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.renew_btn);
            this.Controls.Add(this.member_btn);
            this.Controls.Add(this.new_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button member_btn;
        private System.Windows.Forms.Button renew_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.Button search_id_btn;
        private System.Windows.Forms.Button search_name_btn;
    }
}

