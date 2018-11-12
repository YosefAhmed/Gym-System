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
            this.SuspendLayout();
            // 
            // Enter_pass_lbl
            // 
            this.Enter_pass_lbl.AutoSize = true;
            this.Enter_pass_lbl.Location = new System.Drawing.Point(311, 88);
            this.Enter_pass_lbl.Name = "Enter_pass_lbl";
            this.Enter_pass_lbl.Size = new System.Drawing.Size(173, 13);
            this.Enter_pass_lbl.TabIndex = 0;
            this.Enter_pass_lbl.Text = "Please Enter Your Admin Password";
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(280, 136);
            this.pass_txt.Name = "pass_txt";
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
            // Enter_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.Enter_pass_lbl);
            this.Name = "Enter_pass";
            this.Size = new System.Drawing.Size(811, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter_pass_lbl;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button OK_btn;
    }
}
