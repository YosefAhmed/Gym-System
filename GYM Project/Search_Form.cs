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
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Member M = new Member();
            bool x = search_txt.Text.All(char.IsDigit);
            if (x)
            {
                if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
                    M.search_ID(Convert.ToInt32(search_txt.Text));
            }
            else
            {
                if (M.Check_exist_name(search_txt.Text))
                      M.search_Name(search_txt.Text);
            }
            search1.Show();
            search1.id_txt.Text = M.M_ID;
            search1.name_txt.Text = M.M_Name;
            search1.invit_txt.Text = M.Invitation.ToString();
            search1.freeze_txt.Text = M.Freeze.ToString();
        }

        //private void search_name_Click(object sender, EventArgs e)
        //{
        //    Member m = new Member();
            
        //    m.search_Name(search_txt.Text);
        //    search1.Show();
        //    search1.id_txt.Text = m.M_ID;
        //    search1.name_txt.Text = m.M_Name;
        //    search1.invit_txt.Text = m.Invitation.ToString();
        //    search1.freeze_txt.Text = m.Freeze.ToString();
        //}

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Member M = new Member();
           
            bool x = search_txt.Text.All(char.IsDigit);
            if (x)
            {
                if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
                    M.search_ID(Convert.ToInt32(search_txt.Text));
            }
            else
            {
                if (M.Check_exist_name(search_txt.Text))
                    M.delete_name(search_txt.Text);
            }

        }

        private void Search_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
