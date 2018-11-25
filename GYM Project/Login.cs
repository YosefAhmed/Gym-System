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
            Freeze_txt.Hide();
            Conferm_freez_btn.Hide();
            Stop_freeze_btn.Hide();
            interval_lbl.Hide();
            Freezed_lbl.Hide();
            Freezed_txt.Hide();
        }
       
      
        private void Login_invite_Click(object sender, EventArgs e)
        {
            if (ID_txt.Text == "") MessageBox.Show("Please Enter The ID Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                 Member M = new Member();
                 if (M.Check_exist(Convert.ToInt32(ID_txt.Text)))
                 {
                     Member m = new Member();
                     m.invite(Convert.ToInt32(ID_txt.Text));
                     ID_txt.Text = "";
                 }
            }
        }
     
       
        private void Freeze_btn_Click(object sender, EventArgs e)
        {
            if (ID_txt.Text == "") MessageBox.Show("Please Enter The ID Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                Member M = new Member();
                if (M.Check_exist(Convert.ToInt32(ID_txt.Text)))
                {
                    Freeze_txt.Show();
                    Freeze_btn.Hide();
                    Conferm_freez_btn.Show();
                    Stop_freeze_btn.Show();
                    interval_lbl.Show();
                    Freezed_lbl.Show();
                    Freezed_txt.Show();
                }
            }
        }
  
       
        private void Conferm_freez_btn_Click(object sender, EventArgs e)
        {
            if (Freeze_txt.Text == "") MessageBox.Show("Please Enter Number Of Days You Wont To Freeze !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Member M = new Member();
                   // Length = Convert.ToInt32(Freeze_txt.Text);
                    M.freeze(Convert.ToInt32(Freeze_txt.Text), Convert.ToInt32(ID_txt.Text));
                    Freeze_txt.Text = "";
                    Freeze_txt.Hide();
                    Conferm_freez_btn.Hide();
                    Stop_freeze_btn.Hide();
                    interval_lbl.Hide();
                    Freezed_lbl.Hide();
                    Freezed_txt.Hide();
                    Freeze_btn.Show();
                
            }
        }
      
        
        private void Stop_freeze_btn_Click(object sender, EventArgs e)
        {
            if (Freezed_txt.Text == "") MessageBox.Show("Please Enter Number Of Days You Wont To Freeze !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Member M = new Member();
                M.Cancel_freeze(Convert.ToInt32(Freezed_txt.Text), Convert.ToInt32(ID_txt.Text));
                Freezed_txt.Text = "";
                Freeze_txt.Hide();
                Conferm_freez_btn.Hide();
                Stop_freeze_btn.Hide();
                interval_lbl.Hide();
                Freezed_lbl.Hide();
                Freezed_txt.Hide();
                Freeze_btn.Show();
            }
        }

        private void ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Freeze_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void interval_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Freezed_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Freezed_txt_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
