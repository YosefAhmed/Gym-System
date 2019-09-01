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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (ID_txt.Text == "") MessageBox.Show("Please Enter The ID Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Member m = new Member();
                m.Check(Convert.ToInt32(ID_txt.Text));
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Freeze_txt.Hide();
            //Conferm_freez_btn.Hide();
            //Stop_freeze_btn.Hide();
            //interval_lbl.Hide();
            //Freezed_lbl.Hide();
            //Freezed_txt.Hide();
        }
       
        private void ID_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               Login_btn_Click(sender, e);
            }
        }
    }
}
