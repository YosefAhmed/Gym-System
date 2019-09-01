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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.ID_txt = new System.Windows.Forms.TextBox();
			this.ID_lbl = new System.Windows.Forms.Label();
			this.Login_btn = new System.Windows.Forms.Button();
			this.exit_bar = new System.Windows.Forms.Panel();
			this.X_btn = new System.Windows.Forms.Button();
			this.exit_bar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ID_txt
			// 
			this.ID_txt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID_txt.Location = new System.Drawing.Point(105, 68);
			this.ID_txt.Name = "ID_txt";
			this.ID_txt.Size = new System.Drawing.Size(197, 27);
			this.ID_txt.TabIndex = 0;
			this.ID_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_txt_KeyDown);
			// 
			// ID_lbl
			// 
			this.ID_lbl.AutoSize = true;
			this.ID_lbl.BackColor = System.Drawing.Color.Transparent;
			this.ID_lbl.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ID_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.ID_lbl.Location = new System.Drawing.Point(48, 68);
			this.ID_lbl.Name = "ID_lbl";
			this.ID_lbl.Size = new System.Drawing.Size(43, 29);
			this.ID_lbl.TabIndex = 1;
			this.ID_lbl.Text = "ID";
			// 
			// Login_btn
			// 
			this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
			this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
			this.Login_btn.FlatAppearance.BorderSize = 0;
			this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Login_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Login_btn.ForeColor = System.Drawing.Color.Transparent;
			this.Login_btn.Location = new System.Drawing.Point(100, 120);
			this.Login_btn.Name = "Login_btn";
			this.Login_btn.Size = new System.Drawing.Size(214, 42);
			this.Login_btn.TabIndex = 2;
			this.Login_btn.Text = "Login as a member";
			this.Login_btn.UseVisualStyleBackColor = false;
			this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
			// 
			// exit_bar
			// 
			this.exit_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(50)))), ((int)(((byte)(41)))));
			this.exit_bar.Controls.Add(this.X_btn);
			this.exit_bar.Location = new System.Drawing.Point(0, -1);
			this.exit_bar.Name = "exit_bar";
			this.exit_bar.Size = new System.Drawing.Size(411, 28);
			this.exit_bar.TabIndex = 8;
			// 
			// X_btn
			// 
			this.X_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.X_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
			this.X_btn.FlatAppearance.BorderSize = 0;
			this.X_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.X_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.X_btn.ForeColor = System.Drawing.Color.White;
			this.X_btn.Location = new System.Drawing.Point(372, 0);
			this.X_btn.Name = "X_btn";
			this.X_btn.Size = new System.Drawing.Size(39, 28);
			this.X_btn.TabIndex = 8;
			this.X_btn.Text = "X";
			this.X_btn.UseVisualStyleBackColor = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(410, 232);
			this.Controls.Add(this.exit_bar);
			this.Controls.Add(this.Login_btn);
			this.Controls.Add(this.ID_lbl);
			this.Controls.Add(this.ID_txt);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.exit_bar.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Button Login_btn;
		private System.Windows.Forms.Panel exit_bar;
		private System.Windows.Forms.Button X_btn;
	}
}