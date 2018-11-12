using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Project
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Login_btn_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            if (username_txt.Text == "123" && Password_txt.Text == "123")
            {
                F.Show();
                this.Hide();            
            }
            else
                Wrong_lbl.Text = "* Wrong Username Or Password, Please Try Again !! *";
        }
    }
}
