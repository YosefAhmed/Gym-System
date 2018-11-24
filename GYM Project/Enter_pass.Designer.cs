namespace GYM_Project
{
    partial class Enter_pass
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enter_pass_lbl = new System.Windows.Forms.Label();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Error_msg_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_pass_lbl
            // 
            this.Enter_pass_lbl.AutoSize = true;
            this.Enter_pass_lbl.Location = new System.Drawing.Point(324, 68);
            this.Enter_pass_lbl.Name = "Enter_pass_lbl";
            this.Enter_pass_lbl.Size = new System.Drawing.Size(139, 13);
            this.Enter_pass_lbl.TabIndex = 0;
            this.Enter_pass_lbl.Text = "Please Confitm Your Identity";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(280, 136);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(235, 20);
            this.pass_txt.TabIndex = 1;
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(337, 178);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(115, 40);
            this.OK_btn.TabIndex = 2;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(280, 110);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(235, 20);
            this.username_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "username";
            // 
            // Error_msg_lbl
            // 
            this.Error_msg_lbl.AutoSize = true;
            this.Error_msg_lbl.Location = new System.Drawing.Point(265, 246);
            this.Error_msg_lbl.Name = "Error_msg_lbl";
            this.Error_msg_lbl.Size = new System.Drawing.Size(10, 13);
            this.Error_msg_lbl.TabIndex = 3;
            this.Error_msg_lbl.Text = ".";
            // 
            // Enter_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Error_msg_lbl);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter_pass_lbl);
            this.Name = "Enter_pass";
            this.Size = new System.Drawing.Size(783, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter_pass_lbl;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Error_msg_lbl;
    }
}
