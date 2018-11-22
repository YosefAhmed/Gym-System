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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
        }






    }
}
