namespace GYM_Project
{
    partial class Search_Form
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
            this.search_id_btn = new System.Windows.Forms.Button();
            this.search_name = new System.Windows.Forms.Button();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.Data_view = new System.Windows.Forms.DataGridView();
            this.search1 = new GYM_Project.search();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // search_id_btn
            // 
            this.search_id_btn.Location = new System.Drawing.Point(470, 39);
            this.search_id_btn.Name = "search_id_btn";
            this.search_id_btn.Size = new System.Drawing.Size(77, 50);
            this.search_id_btn.TabIndex = 1;
            this.search_id_btn.Text = "Search With ID ";
            this.search_id_btn.UseVisualStyleBackColor = true;
            this.search_id_btn.Click += new System.EventHandler(this.search_id_btn_Click);
            // 
            // search_name
            // 
            this.search_name.Location = new System.Drawing.Point(570, 39);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(77, 50);
            this.search_name.TabIndex = 1;
            this.search_name.Text = "Search With Name ";
            this.search_name.UseVisualStyleBackColor = true;
            this.search_name.Click += new System.EventHandler(this.search_name_Click);
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(454, 9);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(216, 20);
            this.search_txt.TabIndex = 2;
            // 
            // Data_view
            // 
            this.Data_view.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_view.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.Data_view.Location = new System.Drawing.Point(12, 114);
            this.Data_view.Name = "Data_view";
            this.Data_view.Size = new System.Drawing.Size(409, 231);
            this.Data_view.TabIndex = 3;
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(407, 114);
            this.search1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(290, 231);
            this.search1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Member ID Or Name";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(12, 12);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(94, 46);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete Member";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 356);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_view);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.search_name);
            this.Controls.Add(this.search_id_btn);
            this.Controls.Add(this.search1);
            this.Name = "Search_Form";
            this.Text = "Search_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private search search1;
        private System.Windows.Forms.Button search_id_btn;
        private System.Windows.Forms.Button search_name;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.DataGridView Data_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
    }
}