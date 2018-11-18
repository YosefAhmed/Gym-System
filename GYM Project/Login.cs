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
            if (ID_txt.Text == null) MessageBox.Show("Please Enter The ID Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Member m = new Member();
                m.Check(Convert.ToInt32(ID_txt.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.invite(Convert.ToInt32(ID_txt.Text));
            ID_txt.Text ="";
        }

        private void Freeze_btn_Click(object sender, EventArgs e)
        {
            
            Freeze_txt.Show();
            Freeze_btn.Hide();
            Conferm_freez_btn.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Freeze_txt.Hide();
            Conferm_freez_btn.Hide();
        }
        public static int Length;
        private void Conferm_freez_btn_Click(object sender, EventArgs e)
        {
            Length= Convert.ToInt32(Freeze_txt.Text);
            Member M = new Member();
            M.freeze(Convert.ToInt32(Freeze_txt.Text), Convert.ToInt32(ID_txt.Text));
        }
        
    }
}
