namespace GYM_Project
{
    partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.exit_bar = new System.Windows.Forms.Panel();
			this.X_btn = new System.Windows.Forms.Button();
			this.admin_bar = new System.Windows.Forms.Panel();
			this.adminName_lbl = new System.Windows.Forms.Label();
			this.logout_btn = new System.Windows.Forms.Button();
			this.Search_btn = new System.Windows.Forms.Button();
			this.loginMember_btn = new System.Windows.Forms.Button();
			this.addNew_btn = new System.Windows.Forms.Button();
			this.membersList_btn = new System.Windows.Forms.Button();
			this.finance_btn = new System.Windows.Forms.Button();
			this.employees_btn = new System.Windows.Forms.Button();
			this.settings_btn = new System.Windows.Forms.Button();
			this.exit_bar.SuspendLayout();
			this.admin_bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// exit_bar
			// 
			this.exit_bar.BackColor = System.Drawing.Color.GhostWhite;
			this.exit_bar.Controls.Add(this.X_btn);
			this.exit_bar.Location = new System.Drawing.Point(0, 0);
			this.exit_bar.Name = "exit_bar";
			this.exit_bar.Size = new System.Drawing.Size(652, 28);
			this.exit_bar.TabIndex = 7;
			// 
			// X_btn
			// 
			this.X_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.X_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.X_btn.FlatAppearance.BorderSize = 0;
			this.X_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.X_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.X_btn.ForeColor = System.Drawing.Color.Maroon;
			this.X_btn.Location = new System.Drawing.Point(613, 0);
			this.X_btn.Name = "X_btn";
			this.X_btn.Size = new System.Drawing.Size(39, 28);
			this.X_btn.TabIndex = 8;
			this.X_btn.Text = "X";
			this.X_btn.UseVisualStyleBackColor = false;
			this.X_btn.Click += new System.EventHandler(this.X_btn_Click);
			// 
			// admin_bar
			// 
			this.admin_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(50)))), ((int)(((byte)(41)))));
			this.admin_bar.Controls.Add(this.adminName_lbl);
			this.admin_bar.Controls.Add(this.logout_btn);
			this.admin_bar.Location = new System.Drawing.Point(0, 28);
			this.admin_bar.Name = "admin_bar";
			this.admin_bar.Size = new System.Drawing.Size(652, 54);
			this.admin_bar.TabIndex = 8;
			// 
			// adminName_lbl
			// 
			this.adminName_lbl.AutoSize = true;
			this.adminName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminName_lbl.ForeColor = System.Drawing.Color.GhostWhite;
			this.adminName_lbl.Location = new System.Drawing.Point(12, 17);
			this.adminName_lbl.Name = "adminName_lbl";
			this.adminName_lbl.Size = new System.Drawing.Size(74, 20);
			this.adminName_lbl.TabIndex = 1;
			this.adminName_lbl.Text = "Admin 1";
			// 
			// logout_btn
			// 
			this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
			this.logout_btn.FlatAppearance.BorderSize = 0;
			this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logout_btn.ForeColor = System.Drawing.Color.GhostWhite;
			this.logout_btn.Location = new System.Drawing.Point(596, 0);
			this.logout_btn.Name = "logout_btn";
			this.logout_btn.Size = new System.Drawing.Size(56, 54);
			this.logout_btn.TabIndex = 0;
			this.logout_btn.Text = "logout";
			this.logout_btn.UseVisualStyleBackColor = false;
			// 
			// Search_btn
			// 
			this.Search_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.Search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_btn.BackgroundImage")));
			this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.Search_btn.FlatAppearance.BorderSize = 0;
			this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Search_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Search_btn.ForeColor = System.Drawing.Color.Transparent;
			this.Search_btn.Location = new System.Drawing.Point(416, 231);
			this.Search_btn.Name = "Search_btn";
			this.Search_btn.Size = new System.Drawing.Size(170, 100);
			this.Search_btn.TabIndex = 11;
			this.Search_btn.UseVisualStyleBackColor = false;
			// 
			// loginMember_btn
			// 
			this.loginMember_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.loginMember_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.loginMember_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginMember_btn.BackgroundImage")));
			this.loginMember_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.loginMember_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.loginMember_btn.FlatAppearance.BorderSize = 0;
			this.loginMember_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginMember_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold);
			this.loginMember_btn.ForeColor = System.Drawing.Color.Transparent;
			this.loginMember_btn.Location = new System.Drawing.Point(240, 125);
			this.loginMember_btn.Name = "loginMember_btn";
			this.loginMember_btn.Size = new System.Drawing.Size(170, 100);
			this.loginMember_btn.TabIndex = 10;
			this.loginMember_btn.UseVisualStyleBackColor = false;
			this.loginMember_btn.Click += new System.EventHandler(this.loginMember_btn_Click);
			// 
			// addNew_btn
			// 
			this.addNew_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.addNew_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.addNew_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addNew_btn.BackgroundImage")));
			this.addNew_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.addNew_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.addNew_btn.FlatAppearance.BorderSize = 0;
			this.addNew_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addNew_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold);
			this.addNew_btn.ForeColor = System.Drawing.Color.Transparent;
			this.addNew_btn.Location = new System.Drawing.Point(64, 231);
			this.addNew_btn.Name = "addNew_btn";
			this.addNew_btn.Size = new System.Drawing.Size(170, 100);
			this.addNew_btn.TabIndex = 9;
			this.addNew_btn.UseVisualStyleBackColor = false;
			this.addNew_btn.Click += new System.EventHandler(this.AddNew_btn_Click);
			// 
			// membersList_btn
			// 
			this.membersList_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.membersList_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.membersList_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("membersList_btn.BackgroundImage")));
			this.membersList_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.membersList_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.membersList_btn.FlatAppearance.BorderSize = 0;
			this.membersList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.membersList_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.membersList_btn.ForeColor = System.Drawing.Color.Transparent;
			this.membersList_btn.Location = new System.Drawing.Point(240, 231);
			this.membersList_btn.Name = "membersList_btn";
			this.membersList_btn.Size = new System.Drawing.Size(170, 100);
			this.membersList_btn.TabIndex = 12;
			this.membersList_btn.UseVisualStyleBackColor = false;
			// 
			// finance_btn
			// 
			this.finance_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.finance_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.finance_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("finance_btn.BackgroundImage")));
			this.finance_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.finance_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.finance_btn.FlatAppearance.BorderSize = 0;
			this.finance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.finance_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.finance_btn.ForeColor = System.Drawing.Color.Transparent;
			this.finance_btn.Location = new System.Drawing.Point(64, 337);
			this.finance_btn.Name = "finance_btn";
			this.finance_btn.Size = new System.Drawing.Size(170, 100);
			this.finance_btn.TabIndex = 13;
			this.finance_btn.UseVisualStyleBackColor = false;
			// 
			// employees_btn
			// 
			this.employees_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.employees_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.employees_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employees_btn.BackgroundImage")));
			this.employees_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.employees_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.employees_btn.FlatAppearance.BorderSize = 0;
			this.employees_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.employees_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employees_btn.ForeColor = System.Drawing.Color.Transparent;
			this.employees_btn.Location = new System.Drawing.Point(240, 337);
			this.employees_btn.Name = "employees_btn";
			this.employees_btn.Size = new System.Drawing.Size(170, 100);
			this.employees_btn.TabIndex = 14;
			this.employees_btn.UseVisualStyleBackColor = false;
			// 
			// settings_btn
			// 
			this.settings_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.settings_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.settings_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings_btn.BackgroundImage")));
			this.settings_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.settings_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
			this.settings_btn.FlatAppearance.BorderSize = 0;
			this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settings_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.settings_btn.ForeColor = System.Drawing.Color.Transparent;
			this.settings_btn.Location = new System.Drawing.Point(416, 337);
			this.settings_btn.Name = "settings_btn";
			this.settings_btn.Size = new System.Drawing.Size(170, 100);
			this.settings_btn.TabIndex = 15;
			this.settings_btn.UseVisualStyleBackColor = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(651, 482);
			this.Controls.Add(this.settings_btn);
			this.Controls.Add(this.employees_btn);
			this.Controls.Add(this.finance_btn);
			this.Controls.Add(this.membersList_btn);
			this.Controls.Add(this.Search_btn);
			this.Controls.Add(this.loginMember_btn);
			this.Controls.Add(this.addNew_btn);
			this.Controls.Add(this.admin_bar);
			this.Controls.Add(this.exit_bar);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Resize += new System.EventHandler(this.Main_Resize);
			this.exit_bar.ResumeLayout(false);
			this.admin_bar.ResumeLayout(false);
			this.admin_bar.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel exit_bar;
		private System.Windows.Forms.Button X_btn;
		private System.Windows.Forms.Panel admin_bar;
		public System.Windows.Forms.Button Search_btn;
		public System.Windows.Forms.Button loginMember_btn;
		public System.Windows.Forms.Button addNew_btn;
		public System.Windows.Forms.Button membersList_btn;
		public System.Windows.Forms.Button finance_btn;
		public System.Windows.Forms.Button employees_btn;
		private System.Windows.Forms.Label adminName_lbl;
		private System.Windows.Forms.Button logout_btn;
		public System.Windows.Forms.Button settings_btn;
	}
}

