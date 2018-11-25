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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Search_btn = new System.Windows.Forms.Button();
            this.member_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Search_btn.FlatAppearance.BorderSize = 5;
            this.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.Location = new System.Drawing.Point(565, 208);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(192, 118);
            this.Search_btn.TabIndex = 5;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // member_btn
            // 
            this.member_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.member_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.member_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.member_btn.FlatAppearance.BorderSize = 5;
            this.member_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold);
            this.member_btn.Location = new System.Drawing.Point(311, 208);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(192, 118);
            this.member_btn.TabIndex = 4;
            this.member_btn.Text = "Member";
            this.member_btn.UseVisualStyleBackColor = false;
            this.member_btn.Click += new System.EventHandler(this.member_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.new_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.new_btn.FlatAppearance.BorderSize = 5;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold);
            this.new_btn.Location = new System.Drawing.Point(54, 208);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(192, 118);
            this.new_btn.TabIndex = 3;
            this.new_btn.Text = "New Member";
            this.new_btn.UseVisualStyleBackColor = false;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.member_btn);
            this.Controls.Add(this.new_btn);
            this.DoubleBuffered = true;
            this.Name = "Main_Form";
            this.Size = new System.Drawing.Size(811, 350);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button member_btn;
        private System.Windows.Forms.Button new_btn;
    }
}
