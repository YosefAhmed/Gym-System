using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Project
{
    public partial class Main : Form
    {
        int i = 0;
        public Main()
        {
            
            InitializeComponent();
        }
        public void aperancemax()//for maximize 
        {
           main_Form1.Size = new Size(1366, 650);
          enter_pass1.Size = new Size(1366, 650);
           Back_btn.Size = new Size(100, 40);
           admin_Settings1.Size = new Size(1366, 650);
           main_Form1.new_btn.Location = new Point(270, 358);
           main_Form1.Search_btn.Location = new Point(900, 358);
            Settings_btn.Location = new Point(65, 643);
            Settings_btn.Size = new Size(200,75);
        }
        public void aperancenormal()//for normal
        {
            main_Form1.Size = new Size  (814, 369);
            enter_pass1.Size = new Size(814, 360);
            Back_btn.Size = new Size(89, 35);
            admin_Settings1.Size = new Size(814, 355);
           main_Form1.new_btn.Location = new Point(54, 208);
           main_Form1.Search_btn.Location = new Point(565, 208);
           Settings_btn.Location = new Point(33, 376);
           Settings_btn.Size = new Size(150, 54);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Settings_btn_Click(object sender, EventArgs e)
        {
            this.main_Form1.Hide();
            this.Settings_btn.Hide();
            this.enter_pass1.Show();
            
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.main_Form1.Show();
            this.Settings_btn.Show();
            enter_pass1.pass_txt.Text = null;
            enter_pass1.username_txt.Text = null;
        }



        private void Main_Resize(object sender, EventArgs e)
        {
            if (i==0)
            {
                this.aperancemax();
                i=-1;
            }
            else
            {
                this.aperancenormal();
                i=0;
            }
               
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Member.con.Open();
            SqlCommand cmd = new SqlCommand("USE Gym_;BACKUP DATABASE Gym_ TO DISK = 'E:\\Gym_.Bak' ",Member.con);
            cmd.ExecuteNonQuery();
        }

    }
}
