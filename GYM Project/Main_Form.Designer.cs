namespace GYM_Project
{
    partial class Main_Form
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
            this.Search_btn = new System.Windows.Forms.Button();
            this.member_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(565, 141);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(192, 118);
            this.Search_btn.TabIndex = 5;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // member_btn
            // 
            this.member_btn.Location = new System.Drawing.Point(311, 141);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(192, 118);
            this.member_btn.TabIndex = 4;
            this.member_btn.Text = "Member";
            this.member_btn.UseVisualStyleBackColor = true;
            this.member_btn.Click += new System.EventHandler(this.member_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(54, 141);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(192, 118);
            this.new_btn.TabIndex = 3;
            this.new_btn.Text = "New Member";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.member_btn);
            this.Controls.Add(this.new_btn);
            this.Name = "Main_Form";
            this.Size = new System.Drawing.Size(811, 350);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button member_btn;
        private System.Windows.Forms.Button new_btn;
    }
}
