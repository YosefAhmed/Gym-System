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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void member_btn_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
        }

        private void All_btn_Click(object sender, EventArgs e)
        {
            All_Members A = new All_Members();
            A.Show();
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
        }




    }
}
