namespace GYM_Project
{
    partial class Renewform
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
            this.confirmbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isna = new System.Windows.Forms.RadioButton();
            this.i6shr = new System.Windows.Forms.RadioButton();
            this.i3shr = new System.Windows.Forms.RadioButton();
            this.ishr = new System.Windows.Forms.RadioButton();
            this.in_id = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmbtn
            // 
            this.confirmbtn.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.Location = new System.Drawing.Point(168, 271);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(173, 38);
            this.confirmbtn.TabIndex = 100;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.isna);
            this.groupBox1.Controls.Add(this.i6shr);
            this.groupBox1.Controls.Add(this.i3shr);
            this.groupBox1.Controls.Add(this.ishr);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 146);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the new term";
            // 
            // isna
            // 
            this.isna.AutoSize = true;
            this.isna.ForeColor = System.Drawing.Color.Black;
            this.isna.Location = new System.Drawing.Point(184, 85);
            this.isna.Name = "isna";
            this.isna.Size = new System.Drawing.Size(87, 27);
            this.isna.TabIndex = 3;
            this.isna.TabStop = true;
            this.isna.Text = "1 year";
            this.isna.UseVisualStyleBackColor = true;
            // 
            // i6shr
            // 
            this.i6shr.AutoSize = true;
            this.i6shr.ForeColor = System.Drawing.Color.Black;
            this.i6shr.Location = new System.Drawing.Point(6, 85);
            this.i6shr.Name = "i6shr";
            this.i6shr.Size = new System.Drawing.Size(118, 27);
            this.i6shr.TabIndex = 2;
            this.i6shr.TabStop = true;
            this.i6shr.Text = "6 months";
            this.i6shr.UseVisualStyleBackColor = true;
            // 
            // i3shr
            // 
            this.i3shr.AutoSize = true;
            this.i3shr.ForeColor = System.Drawing.Color.Black;
            this.i3shr.Location = new System.Drawing.Point(184, 38);
            this.i3shr.Name = "i3shr";
            this.i3shr.Size = new System.Drawing.Size(118, 27);
            this.i3shr.TabIndex = 1;
            this.i3shr.TabStop = true;
            this.i3shr.Text = "3 months";
            this.i3shr.UseVisualStyleBackColor = true;
            // 
            // ishr
            // 
            this.ishr.AutoSize = true;
            this.ishr.ForeColor = System.Drawing.Color.Black;
            this.ishr.Location = new System.Drawing.Point(6, 38);
            this.ishr.Name = "ishr";
            this.ishr.Size = new System.Drawing.Size(108, 27);
            this.ishr.TabIndex = 0;
            this.ishr.TabStop = true;
            this.ishr.Text = "1 month";
            this.ishr.UseVisualStyleBackColor = true;
            // 
            // in_id
            // 
            this.in_id.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.in_id.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_id.Location = new System.Drawing.Point(104, 32);
            this.in_id.Multiline = true;
            this.in_id.Name = "in_id";
            this.in_id.ReadOnly = true;
            this.in_id.Size = new System.Drawing.Size(257, 35);
            this.in_id.TabIndex = 98;
            this.in_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idlbl
            // 
            this.idlbl.BackColor = System.Drawing.Color.Transparent;
            this.idlbl.Font = new System.Drawing.Font("Tahoma", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(18, 32);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(81, 35);
            this.idlbl.TabIndex = 97;
            this.idlbl.Text = "ID : ";
            // 
            // Renewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 332);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.in_id);
            this.Controls.Add(this.idlbl);
            this.MaximizeBox = false;
            this.Name = "Renewform";
            this.Text = "Renewform";
            this.Load += new System.EventHandler(this.Renewform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton isna;
        private System.Windows.Forms.RadioButton i6shr;
        private System.Windows.Forms.RadioButton i3shr;
        private System.Windows.Forms.RadioButton ishr;
        private System.Windows.Forms.TextBox in_id;
        private System.Windows.Forms.Label idlbl;
    }
}