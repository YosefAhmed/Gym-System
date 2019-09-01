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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
			this.username_txt = new System.Windows.Forms.TextBox();
			this.Password_txt = new System.Windows.Forms.TextBox();
			this.username_lbl = new System.Windows.Forms.Label();
			this.password_lbl = new System.Windows.Forms.Label();
			this.Admin_Login_btn = new System.Windows.Forms.Button();
			this.Wrong_lbl = new System.Windows.Forms.Label();
			this.exit_bar = new System.Windows.Forms.Panel();
			this.X_btn = new System.Windows.Forms.Button();
			this.exit_bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// username_txt
			// 
			this.username_txt.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_txt.Location = new System.Drawing.Point(177, 87);
			this.username_txt.Name = "username_txt";
			this.username_txt.Size = new System.Drawing.Size(190, 24);
			this.username_txt.TabIndex = 0;
			this.username_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_txt_KeyDown);
			// 
			// Password_txt
			// 
			this.Password_txt.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_txt.Location = new System.Drawing.Point(177, 132);
			this.Password_txt.Name = "Password_txt";
			this.Password_txt.PasswordChar = '*';
			this.Password_txt.Size = new System.Drawing.Size(190, 24);
			this.Password_txt.TabIndex = 1;
			this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
			this.Password_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_txt_KeyDown);
			// 
			// username_lbl
			// 
			this.username_lbl.AutoSize = true;
			this.username_lbl.BackColor = System.Drawing.Color.Transparent;
			this.username_lbl.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.username_lbl.Location = new System.Drawing.Point(12, 87);
			this.username_lbl.Name = "username_lbl";
			this.username_lbl.Size = new System.Drawing.Size(148, 19);
			this.username_lbl.TabIndex = 2;
			this.username_lbl.Text = "Admin Username";
			// 
			// password_lbl
			// 
			this.password_lbl.AutoSize = true;
			this.password_lbl.BackColor = System.Drawing.Color.Transparent;
			this.password_lbl.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.password_lbl.Location = new System.Drawing.Point(12, 133);
			this.password_lbl.Name = "password_lbl";
			this.password_lbl.Size = new System.Drawing.Size(144, 19);
			this.password_lbl.TabIndex = 3;
			this.password_lbl.Text = "Admin Password";
			// 
			// Admin_Login_btn
			// 
			this.Admin_Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.Admin_Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
			this.Admin_Login_btn.FlatAppearance.BorderSize = 0;
			this.Admin_Login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
			this.Admin_Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.Admin_Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Admin_Login_btn.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Admin_Login_btn.ForeColor = System.Drawing.Color.Transparent;
			this.Admin_Login_btn.Location = new System.Drawing.Point(91, 181);
			this.Admin_Login_btn.Name = "Admin_Login_btn";
			this.Admin_Login_btn.Size = new System.Drawing.Size(215, 42);
			this.Admin_Login_btn.TabIndex = 4;
			this.Admin_Login_btn.Text = "Login";
			this.Admin_Login_btn.UseVisualStyleBackColor = false;
			this.Admin_Login_btn.Click += new System.EventHandler(this.Admin_Login_btn_Click);
			// 
			// Wrong_lbl
			// 
			this.Wrong_lbl.AutoSize = true;
			this.Wrong_lbl.BackColor = System.Drawing.Color.Transparent;
			this.Wrong_lbl.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Wrong_lbl.ForeColor = System.Drawing.Color.Gold;
			this.Wrong_lbl.Location = new System.Drawing.Point(23, 229);
			this.Wrong_lbl.Name = "Wrong_lbl";
			this.Wrong_lbl.Size = new System.Drawing.Size(0, 19);
			this.Wrong_lbl.TabIndex = 5;
			// 
			// exit_bar
			// 
			this.exit_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(50)))), ((int)(((byte)(41)))));
			this.exit_bar.Controls.Add(this.X_btn);
			this.exit_bar.Location = new System.Drawing.Point(0, 0);
			this.exit_bar.Name = "exit_bar";
			this.exit_bar.Size = new System.Drawing.Size(383, 28);
			this.exit_bar.TabIndex = 97;
			// 
			// X_btn
			// 
			this.X_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.X_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
			this.X_btn.FlatAppearance.BorderSize = 0;
			this.X_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.X_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.X_btn.ForeColor = System.Drawing.Color.White;
			this.X_btn.Location = new System.Drawing.Point(344, 0);
			this.X_btn.Name = "X_btn";
			this.X_btn.Size = new System.Drawing.Size(39, 28);
			this.X_btn.TabIndex = 8;
			this.X_btn.Text = "X";
			this.X_btn.UseVisualStyleBackColor = false;
			// 
			// Admin_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(382, 281);
			this.Controls.Add(this.exit_bar);
			this.Controls.Add(this.Wrong_lbl);
			this.Controls.Add(this.Admin_Login_btn);
			this.Controls.Add(this.password_lbl);
			this.Controls.Add(this.username_lbl);
			this.Controls.Add(this.Password_txt);
			this.Controls.Add(this.username_txt);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Admin_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin_Login";
			this.Load += new System.EventHandler(this.Admin_Login_Load);
			this.exit_bar.ResumeLayout(false);
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
		private System.Windows.Forms.Panel exit_bar;
		private System.Windows.Forms.Button X_btn;
	}
}