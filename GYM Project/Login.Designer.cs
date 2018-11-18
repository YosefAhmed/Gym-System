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
            this.Login_invite = new System.Windows.Forms.Button();
            this.Freeze_btn = new System.Windows.Forms.Button();
            this.Freeze_txt = new System.Windows.Forms.TextBox();
            this.Conferm_freez_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(102, 68);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(197, 20);
            this.ID_txt.TabIndex = 0;
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_lbl.Location = new System.Drawing.Point(60, 67);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(26, 20);
            this.ID_lbl.TabIndex = 1;
            this.ID_lbl.Text = "ID";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(124, 109);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(142, 40);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login as a member";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login_invite
            // 
            this.Login_invite.Location = new System.Drawing.Point(316, 207);
            this.Login_invite.Name = "Login_invite";
            this.Login_invite.Size = new System.Drawing.Size(71, 40);
            this.Login_invite.TabIndex = 3;
            this.Login_invite.Text = "Invite";
            this.Login_invite.UseVisualStyleBackColor = true;
            this.Login_invite.Click += new System.EventHandler(this.button1_Click);
            // 
            // Freeze_btn
            // 
            this.Freeze_btn.Location = new System.Drawing.Point(15, 207);
            this.Freeze_btn.Name = "Freeze_btn";
            this.Freeze_btn.Size = new System.Drawing.Size(71, 40);
            this.Freeze_btn.TabIndex = 4;
            this.Freeze_btn.Text = "Freeze";
            this.Freeze_btn.UseVisualStyleBackColor = true;
            this.Freeze_btn.Click += new System.EventHandler(this.Freeze_btn_Click);
            // 
            // Freeze_txt
            // 
            this.Freeze_txt.Location = new System.Drawing.Point(102, 218);
            this.Freeze_txt.Name = "Freeze_txt";
            this.Freeze_txt.Size = new System.Drawing.Size(94, 20);
            this.Freeze_txt.TabIndex = 5;
            // 
            // Conferm_freez_btn
            // 
            this.Conferm_freez_btn.Location = new System.Drawing.Point(15, 207);
            this.Conferm_freez_btn.Name = "Conferm_freez_btn";
            this.Conferm_freez_btn.Size = new System.Drawing.Size(71, 40);
            this.Conferm_freez_btn.TabIndex = 6;
            this.Conferm_freez_btn.Text = "Freeze";
            this.Conferm_freez_btn.UseVisualStyleBackColor = true;
            this.Conferm_freez_btn.Click += new System.EventHandler(this.Conferm_freez_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 259);
            this.Controls.Add(this.Conferm_freez_btn);
            this.Controls.Add(this.Freeze_txt);
            this.Controls.Add(this.Freeze_btn);
            this.Controls.Add(this.Login_invite);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.ID_lbl);
            this.Controls.Add(this.ID_txt);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Login_invite;
        private System.Windows.Forms.Button Freeze_btn;
        private System.Windows.Forms.TextBox Freeze_txt;
        private System.Windows.Forms.Button Conferm_freez_btn;
    }
}