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
            this.Login_invite = new System.Windows.Forms.Button();
            this.Freeze_btn = new System.Windows.Forms.Button();
            this.Freeze_txt = new System.Windows.Forms.TextBox();
            this.Conferm_freez_btn = new System.Windows.Forms.Button();
            this.Stop_freeze_btn = new System.Windows.Forms.Button();
            this.interval_lbl = new System.Windows.Forms.Label();
            this.Freezed_lbl = new System.Windows.Forms.Label();
            this.Freezed_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ID_txt
            // 
            this.ID_txt.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_txt.Location = new System.Drawing.Point(192, 50);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(197, 27);
            this.ID_txt.TabIndex = 0;
            this.ID_txt.TextChanged += new System.EventHandler(this.ID_txt_TextChanged);
            this.ID_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_txt_KeyDown);
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ID_lbl.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lbl.ForeColor = System.Drawing.Color.OldLace;
            this.ID_lbl.Location = new System.Drawing.Point(118, 50);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(43, 29);
            this.ID_lbl.TabIndex = 1;
            this.ID_lbl.Text = "ID";
            this.ID_lbl.Click += new System.EventHandler(this.ID_lbl_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Yellow;
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.Login_btn.FlatAppearance.BorderSize = 3;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(182, 114);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(214, 42);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login as a member";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login_invite
            // 
            this.Login_invite.BackColor = System.Drawing.Color.Yellow;
            this.Login_invite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_invite.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.Login_invite.FlatAppearance.BorderSize = 3;
            this.Login_invite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Login_invite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Login_invite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_invite.Font = new System.Drawing.Font("Tahoma", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_invite.Location = new System.Drawing.Point(506, 221);
            this.Login_invite.Name = "Login_invite";
            this.Login_invite.Size = new System.Drawing.Size(123, 66);
            this.Login_invite.TabIndex = 3;
            this.Login_invite.Text = "Invite";
            this.Login_invite.UseVisualStyleBackColor = false;
            this.Login_invite.Click += new System.EventHandler(this.Login_invite_Click);
            // 
            // Freeze_btn
            // 
            this.Freeze_btn.BackColor = System.Drawing.Color.Yellow;
            this.Freeze_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.Freeze_btn.FlatAppearance.BorderSize = 3;
            this.Freeze_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Freeze_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Freeze_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Freeze_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freeze_btn.Location = new System.Drawing.Point(20, 221);
            this.Freeze_btn.Name = "Freeze_btn";
            this.Freeze_btn.Size = new System.Drawing.Size(97, 66);
            this.Freeze_btn.TabIndex = 4;
            this.Freeze_btn.Text = "Freeze";
            this.Freeze_btn.UseVisualStyleBackColor = false;
            this.Freeze_btn.Click += new System.EventHandler(this.Freeze_btn_Click);
            // 
            // Freeze_txt
            // 
            this.Freeze_txt.Location = new System.Drawing.Point(305, 219);
            this.Freeze_txt.Name = "Freeze_txt";
            this.Freeze_txt.Size = new System.Drawing.Size(141, 20);
            this.Freeze_txt.TabIndex = 5;
            this.Freeze_txt.TextChanged += new System.EventHandler(this.Freeze_txt_TextChanged);
            // 
            // Conferm_freez_btn
            // 
            this.Conferm_freez_btn.BackColor = System.Drawing.Color.Yellow;
            this.Conferm_freez_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.Conferm_freez_btn.FlatAppearance.BorderSize = 3;
            this.Conferm_freez_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Conferm_freez_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Conferm_freez_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conferm_freez_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conferm_freez_btn.Location = new System.Drawing.Point(25, 199);
            this.Conferm_freez_btn.Name = "Conferm_freez_btn";
            this.Conferm_freez_btn.Size = new System.Drawing.Size(82, 40);
            this.Conferm_freez_btn.TabIndex = 6;
            this.Conferm_freez_btn.Text = "Freeze";
            this.Conferm_freez_btn.UseVisualStyleBackColor = false;
            this.Conferm_freez_btn.Click += new System.EventHandler(this.Conferm_freez_btn_Click);
            // 
            // Stop_freeze_btn
            // 
            this.Stop_freeze_btn.BackColor = System.Drawing.Color.Yellow;
            this.Stop_freeze_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.Stop_freeze_btn.FlatAppearance.BorderSize = 3;
            this.Stop_freeze_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Stop_freeze_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Stop_freeze_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_freeze_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_freeze_btn.Location = new System.Drawing.Point(25, 271);
            this.Stop_freeze_btn.Name = "Stop_freeze_btn";
            this.Stop_freeze_btn.Size = new System.Drawing.Size(82, 40);
            this.Stop_freeze_btn.TabIndex = 7;
            this.Stop_freeze_btn.Text = "Stop Freeze";
            this.Stop_freeze_btn.UseVisualStyleBackColor = false;
            this.Stop_freeze_btn.Click += new System.EventHandler(this.Stop_freeze_btn_Click);
            // 
            // interval_lbl
            // 
            this.interval_lbl.AutoSize = true;
            this.interval_lbl.BackColor = System.Drawing.Color.Transparent;
            this.interval_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interval_lbl.ForeColor = System.Drawing.Color.OldLace;
            this.interval_lbl.Location = new System.Drawing.Point(130, 221);
            this.interval_lbl.Name = "interval_lbl";
            this.interval_lbl.Size = new System.Drawing.Size(154, 20);
            this.interval_lbl.TabIndex = 8;
            this.interval_lbl.Text = "Interval Of Freeze";
            this.interval_lbl.Click += new System.EventHandler(this.interval_lbl_Click);
            // 
            // Freezed_lbl
            // 
            this.Freezed_lbl.AutoSize = true;
            this.Freezed_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Freezed_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Freezed_lbl.ForeColor = System.Drawing.Color.OldLace;
            this.Freezed_lbl.Location = new System.Drawing.Point(128, 271);
            this.Freezed_lbl.Name = "Freezed_lbl";
            this.Freezed_lbl.Size = new System.Drawing.Size(140, 20);
            this.Freezed_lbl.TabIndex = 9;
            this.Freezed_lbl.Text = "Interval Freezed";
            this.Freezed_lbl.Click += new System.EventHandler(this.Freezed_lbl_Click);
            // 
            // Freezed_txt
            // 
            this.Freezed_txt.Location = new System.Drawing.Point(305, 271);
            this.Freezed_txt.Name = "Freezed_txt";
            this.Freezed_txt.Size = new System.Drawing.Size(141, 20);
            this.Freezed_txt.TabIndex = 10;
            this.Freezed_txt.TextChanged += new System.EventHandler(this.Freezed_txt_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 358);
            this.Controls.Add(this.Freezed_txt);
            this.Controls.Add(this.Freezed_lbl);
            this.Controls.Add(this.interval_lbl);
            this.Controls.Add(this.Stop_freeze_btn);
            this.Controls.Add(this.Conferm_freez_btn);
            this.Controls.Add(this.Freeze_txt);
            this.Controls.Add(this.Freeze_btn);
            this.Controls.Add(this.Login_invite);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.ID_txt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Freeze_btn;
        private System.Windows.Forms.TextBox Freeze_txt;
        private System.Windows.Forms.Button Conferm_freez_btn;
        private System.Windows.Forms.Button Stop_freeze_btn;
        private System.Windows.Forms.Label interval_lbl;
        private System.Windows.Forms.Label Freezed_lbl;
        private System.Windows.Forms.TextBox Freezed_txt;
        private System.Windows.Forms.Button Login_invite;
    }
}