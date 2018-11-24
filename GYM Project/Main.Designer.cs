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
            this.Settings_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.main_Form1 = new GYM_Project.Main_Form();
            this.enter_pass1 = new GYM_Project.Enter_pass();
            this.admin_Settings1 = new GYM_Project.Admin_Settings();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Settings_btn
            // 
            this.Settings_btn.Location = new System.Drawing.Point(12, 386);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(115, 23);
            this.Settings_btn.TabIndex = 5;
            this.Settings_btn.Text = "Admin Settings";
            this.Settings_btn.UseVisualStyleBackColor = true;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Back_btn
            // 
            this.Back_btn.Location = new System.Drawing.Point(713, 0);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(89, 42);
            this.Back_btn.TabIndex = 9;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // main_Form1
            // 
            this.main_Form1.Location = new System.Drawing.Point(3, 0);
            this.main_Form1.Name = "main_Form1";
            this.main_Form1.Size = new System.Drawing.Size(811, 369);
            this.main_Form1.TabIndex = 4;
            this.main_Form1.Load += new System.EventHandler(this.main_Form1_Load);
            // 
            // enter_pass1
            // 
            this.enter_pass1.Location = new System.Drawing.Point(0, 0);
            this.enter_pass1.Name = "enter_pass1";
            this.enter_pass1.Size = new System.Drawing.Size(811, 350);
            this.enter_pass1.TabIndex = 10;
            // 
            // admin_Settings1
            // 
            this.admin_Settings1.Location = new System.Drawing.Point(0, 0);
            this.admin_Settings1.Name = "admin_Settings1";
            this.admin_Settings1.Size = new System.Drawing.Size(814, 414);
            this.admin_Settings1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Admin accounts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.main_Form1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Settings_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.enter_pass1);
            this.Controls.Add(this.admin_Settings1);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Admin_Settings admin_Settings1;
        private Main_Form main_Form1;
        private  System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Back_btn;
        private Enter_pass enter_pass1;
        private System.Windows.Forms.Button button1;
    }
}

