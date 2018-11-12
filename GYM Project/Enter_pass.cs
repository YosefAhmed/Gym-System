using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Project
{
    public partial class Enter_pass : UserControl
    {
        public Enter_pass()
        {
            InitializeComponent();
        }
        public bool flag = false;
        private void OK_btn_Click(object sender, EventArgs e)
        {
            if (pass_txt.Text == "123")
            {
                flag = true;
                pass_txt.Text = null;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password !", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
