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
            this.Settings_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.main_Form1 = new GYM_Project.Main_Form();
            this.enter_pass1 = new GYM_Project.Enter_pass();
            this.admin_Settings1 = new GYM_Project.Admin_Settings();
            this.SuspendLayout();
            // 
            // Settings_btn
            // 
            this.Settings_btn.BackColor = System.Drawing.Color.Yellow;
            this.Settings_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.Settings_btn.FlatAppearance.BorderSize = 3;
            this.Settings_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Settings_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold);
            this.Settings_btn.Location = new System.Drawing.Point(33, 376);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(150, 54);
            this.Settings_btn.TabIndex = 5;
            this.Settings_btn.Text = "Admin Settings";
            this.Settings_btn.UseVisualStyleBackColor = false;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Yellow;
            this.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.Back_btn.FlatAppearance.BorderSize = 3;
            this.Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.Back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(678, 36);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(89, 35);
            this.Back_btn.TabIndex = 9;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // main_Form1
            // 
            this.main_Form1.BackColor = System.Drawing.Color.Black;
            this.main_Form1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_Form1.BackgroundImage")));
            this.main_Form1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_Form1.Location = new System.Drawing.Point(0, -1);
            this.main_Form1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.main_Form1.Name = "main_Form1";
            this.main_Form1.Size = new System.Drawing.Size(814, 369);
            this.main_Form1.TabIndex = 4;
            this.main_Form1.Load += new System.EventHandler(this.main_Form1_Load);
            // 
            // enter_pass1
            // 
            this.enter_pass1.BackColor = System.Drawing.Color.Transparent;
            this.enter_pass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter_pass1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enter_pass1.Location = new System.Drawing.Point(0, 28);
            this.enter_pass1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enter_pass1.Name = "enter_pass1";
            this.enter_pass1.Size = new System.Drawing.Size(814, 360);
            this.enter_pass1.TabIndex = 10;
            // 
            // admin_Settings1
            // 
            this.admin_Settings1.BackColor = System.Drawing.Color.Transparent;
            this.admin_Settings1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_Settings1.BackgroundImage")));
            this.admin_Settings1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.admin_Settings1.Location = new System.Drawing.Point(0, 28);
            this.admin_Settings1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.admin_Settings1.Name = "admin_Settings1";
            this.admin_Settings1.Size = new System.Drawing.Size(814, 355);
            this.admin_Settings1.TabIndex = 3;
            this.admin_Settings1.Load += new System.EventHandler(this.admin_Settings1_Load);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 421);
            this.Controls.Add(this.Settings_btn);
            this.Controls.Add(this.main_Form1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.enter_pass1);
            this.Controls.Add(this.admin_Settings1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Admin_Settings admin_Settings1;
        private Main_Form main_Form1;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Button Back_btn;
        private Enter_pass enter_pass1;
    }
}

