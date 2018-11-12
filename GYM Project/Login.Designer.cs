namespace GYM_Project
{
    partial class Login
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
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.ID_lbl = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(102, 69);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(197, 20);
            this.ID_txt.TabIndex = 0;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(53, 72);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(18, 13);
            this.ID_lbl.TabIndex = 1;
            this.ID_lbl.Text = "ID";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(151, 109);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(91, 40);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 259);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.ID_txt);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Button Login_btn;
    }
}