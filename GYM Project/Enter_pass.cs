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

            Member M = new Member();
            if (M.check_manager(username_txt.Text, pass_txt.Text))
            {
                flag = true;
                pass_txt.Text = null;
                this.Hide();
            }
            else
                Error_msg_lbl.Text = "* Wrong Username Or Password, Please Try Again !! *";
        }

        private void Enter_pass_Load(object sender, EventArgs e)
        {

        }

        private void pass_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK_btn_Click(sender, e);
            }
        }

        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK_btn_Click(sender, e);
            }
        }
    }
}
