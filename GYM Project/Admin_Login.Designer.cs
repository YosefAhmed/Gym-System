namespace GYM_Project
{
    partial class Admin_Login
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
            this.username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.Admin_Login_btn = new System.Windows.Forms.Button();
            this.Wrong_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(154, 37);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(190, 20);
            this.username_txt.TabIndex = 0;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(154, 83);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(190, 20);
            this.Password_txt.TabIndex = 1;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(44, 40);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(87, 13);
            this.username_lbl.TabIndex = 2;
            this.username_lbl.Text = "Admin Username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(44, 86);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(85, 13);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Admin Password";
            // 
            // Admin_Login_btn
            // 
            this.Admin_Login_btn.Location = new System.Drawing.Point(144, 127);
            this.Admin_Login_btn.Name = "Admin_Login_btn";
            this.Admin_Login_btn.Size = new System.Drawing.Size(139, 47);
            this.Admin_Login_btn.TabIndex = 4;
            this.Admin_Login_btn.Text = "Login";
            this.Admin_Login_btn.UseVisualStyleBackColor = true;
            this.Admin_Login_btn.Click += new System.EventHandler(this.Admin_Login_btn_Click);
            // 
            // Wrong_lbl
            // 
            this.Wrong_lbl.AutoSize = true;
            this.Wrong_lbl.Location = new System.Drawing.Point(44, 211);
            this.Wrong_lbl.Name = "Wrong_lbl";
            this.Wrong_lbl.Size = new System.Drawing.Size(128, 13);
            this.Wrong_lbl.TabIndex = 5;
            this.Wrong_lbl.Text = "(Wrong usernam or pass )";
            // 
            // Admin_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 258);
            this.Controls.Add(this.Wrong_lbl);
            this.Controls.Add(this.Admin_Login_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.username_txt);
            this.Name = "Admin_Login";
            this.Text = "Admin_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button Admin_Login_btn;
        private System.Windows.Forms.Label Wrong_lbl;
    }
}