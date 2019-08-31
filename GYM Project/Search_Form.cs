using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace GYM_Project
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
            search1.Hide();
            delete_btn.Hide();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            //search1.Hide();
            //Member M = new Member();
            //if (search_txt.Text == "") MessageBox.Show("Please Enter The ID or name Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{

            //bool x = search_txt.Text.All(char.IsDigit);
            //if (x)
            //{
            //    if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
            //    {
            //        M.search_ID(Convert.ToInt32(search_txt.Text));
            //        search1.Show();
            //        delete_btn.Show();
            //    }
            //}
            //else
            //{
            //    if (M.Check_exist_name(search_txt.Text))
            //    {
            //        M.search_Name(search_txt.Text);
            //        search1.Show();
            //        delete_btn.Show();
            //        }
            //}

            //search1.id_txt.Text = M.M_ID;
            //search1.name_txt.Text = M.M_Name;
            //search1.invit_txt.Text = M.Invitation.ToString();
            //search1.freeze_txt.Text = M.Freeze.ToString();

        }

        
            

        private void delete_btn_Click(object sender, EventArgs e)
        {
            //Member M = new Member();
            //if (search_txt.Text == "") MessageBox.Show("Please Enter The ID or name Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //else
            //{

            //bool x = search_txt.Text.All(char.IsDigit);
            //if (x)
            //{
            //    if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
            //        M.delete(Convert.ToInt32(search_txt.Text));
            //}
            //else
            //{
            //    if (M.Check_exist_name(search_txt.Text))
            //        M.delete_name(search_txt.Text);
            //}
            //}
            //search1.Hide();
            //delete_btn.Hide();
            //search_txt.Text = "";
        }

        

        private void Search_Form_Load(object sender, EventArgs e)
        {
            search_txt.Focus();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allusers_btn_Click(object sender, EventArgs e)
        {

           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void conusers_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void endedusers_btn_Click(object sender, EventArgs e)
        {

            
        }

        private void search_txt_Enter(object sender, EventArgs e)
        {
            
        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn_Click(sender, e);
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void search1_Load(object sender, EventArgs e)
        {

        }
    }
}
