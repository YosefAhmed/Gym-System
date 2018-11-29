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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IAQJRV6\SQLEXPRESS;Initial Catalog=Gym_;Integrated Security=True");
        private void search_btn_Click(object sender, EventArgs e)
        {
            search1.Hide();
            Member M = new Member();
            if (search_txt.Text == "") MessageBox.Show("Please Enter The ID or name Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

            bool x = search_txt.Text.All(char.IsDigit);
            if (x)
            {
                if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
                {
                    M.search_ID(Convert.ToInt32(search_txt.Text));
                    search1.Show();
                    delete_btn.Show();
                }
            }
            else
            {
                if (M.Check_exist_name(search_txt.Text))
                {
                    M.search_Name(search_txt.Text);
                    search1.Show();
                    delete_btn.Show();
                    }
            }

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
            }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Member M = new Member();
            if (search_txt.Text == "") MessageBox.Show("Please Enter The ID or name Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

            bool x = search_txt.Text.All(char.IsDigit);
            if (x)
            {
                if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
                    M.delete(Convert.ToInt32(search_txt.Text));
            }
            else
            {
                if (M.Check_exist_name(search_txt.Text))
                    M.delete_name(search_txt.Text);
            }
            }
            search1.Hide();
            delete_btn.Hide();
            search_txt.Text = "";
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

            string start;
            flowLayoutPanel1.Controls.Clear();
            SqlCommand cmd = new SqlCommand("Select * from member", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                panel2.Show();
                flowLayoutPanel1.Show();
                Record us = new Record();
                start = dr["Start_day"].ToString() + "-" + dr["Start_month"].ToString() + "-" + dr["Start_Year"].ToString();
               us.put(dr["ID"].ToString(), dr["Name"].ToString(), dr["Term"].ToString(), dr["Phone"].ToString(), start, dr["end_date_outfreeze"].ToString(), dr["Freeze"].ToString(), dr["invite"].ToString(), dr["count"].ToString());
                flowLayoutPanel1.Controls.Add(us);
            }
            dr.Close();
            con.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void conusers_btn_Click(object sender, EventArgs e)
        {
            string start;
            flowLayoutPanel1.Controls.Clear();
            SqlCommand cmd = new SqlCommand("Select * from member", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] format = { "yyyy-MM-dd" };
                DateTime s;
                DateTime.TryParseExact(dr["end_date_outfreeze"].ToString(), format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out s);
                if (DateTime.Today <= s)
                {
                    start = dr["Start_day"].ToString() + "-" + dr["Start_month"].ToString() + "-" + dr["Start_Year"].ToString();
                    panel2.Show();
                    flowLayoutPanel1.Show();
                    Record us = new Record();
                    us.put(dr["ID"].ToString(), dr["Name"].ToString(), dr["Term"].ToString(), dr["Phone"].ToString(), start, dr["end_date_outfreeze"].ToString(), dr["Freeze"].ToString(), dr["invite"].ToString(), dr["count"].ToString());
                    flowLayoutPanel1.Controls.Add(us);
                }
            }
            dr.Close();
            con.Close();
        }

        private void endedusers_btn_Click(object sender, EventArgs e)
        {

            string start;
            flowLayoutPanel1.Controls.Clear();
            SqlCommand cmd = new SqlCommand("Select * from member", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string[] format = { "yyyy-MM-dd" };
                DateTime s;
                DateTime.TryParseExact(dr["end_date_outfreeze"].ToString(), format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out s);
            
                    if (DateTime.Today >s)
                    {
                    start = dr["Start_day"].ToString() + "-" + dr["Start_month"].ToString() + "-" + dr["Start_Year"].ToString();
                    panel2.Show();
                        flowLayoutPanel1.Show();
                        Record us = new Record();
                        us.put(dr["ID"].ToString(), dr["Name"].ToString(), dr["Term"].ToString(), dr["Phone"].ToString(), start, dr["end_date_outfreeze"].ToString(), dr["Freeze"].ToString(), dr["invite"].ToString(), dr["count"].ToString());
                        flowLayoutPanel1.Controls.Add(us);
                    }    
            }
            dr.Close();
            con.Close();

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
