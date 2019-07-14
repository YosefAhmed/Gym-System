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
        }
        Member M = new Member();
        SqlCommand cmd;
        SqlDataReader dr;
        private void search_btn_Click(object sender, EventArgs e)
        {
            search1.Hide();
            repay_btn.Hide();
            if (search_txt.Text == "") MessageBox.Show("Please Enter The ID or name Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                bool x = search_txt.Text.All(char.IsDigit);
                if (x)
                {
                    if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
                    {
                        M.search_ID(Convert.ToInt32(search_txt.Text));                        
                    }
                }
                else
                {
                    if (M.Check_exist_name(search_txt.Text))
                    {
                        M.search_Name(search_txt.Text);
                    }
                }

                search1.id_txt.Text = M.M_ID;
                search1.name_txt.Text = M.M_Name;
                search1.invit_txt.Text = M.Invitation.ToString();
                search1.freeze_txt.Text = M.Freeze.ToString();
                search1.R_txt.Text = M.remaind.ToString();
                search1.L_Paid_txt.Text = M.paid.ToString();
                search1.Show();
                delete_btn.Show();
                if(Convert.ToInt16(search1.R_txt.Text)>0)
                    repay_btn.Show();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (search_txt.Text == "") MessageBox.Show("Please Enter The ID or name Of The Member !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                bool x = search_txt.Text.All(char.IsDigit);
                if (x)
                {
                    if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
                    {
                        DialogResult del = MessageBox.Show("Are you Sure you want to delete: '" + search_txt.Text + "'", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (del == DialogResult.Yes)
                        {
                            M.delete(Convert.ToInt32(search_txt.Text));
                            delete_btn.Hide();
                            search1.Hide();
                            search_txt.Clear();
                        }
                    }
                }
                else
                {
                    if (M.Check_exist_name(search_txt.Text))
                    {
                        DialogResult del = MessageBox.Show("Are you Sure you want to delete: '" + search_txt.Text + "'", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (del == DialogResult.Yes)
                        {
                            M.delete_name(search_txt.Text);
                            delete_btn.Hide();
                            search1.Hide();
                            search_txt.Clear();
                        }
                    }
                }
            }
        }

        

        private void Search_Form_Load(object sender, EventArgs e)
        {
            search_txt.Focus();
            search1.Hide();
            delete_btn.Hide();
            repay_box.Hide();
            repay_btn.Hide();
        }
        private void allusers_btn_Click(object sender, EventArgs e)
        {

            string start;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(panel2);
            cmd = new SqlCommand("Select * from member", Member.con);
            Member.con.Open();
           dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                panel2.Show();
                flowLayoutPanel1.Show();
                Record us = new Record();
                start = dr["Start_day"].ToString() + "-" + dr["Start_month"].ToString() + "-" + dr["Start_Year"].ToString();
                us.put(dr["ID"].ToString(), dr["Name"].ToString(), dr["Term"].ToString(), dr["Phone"].ToString(), start, dr["end_date_outfreeze"].ToString(), dr["Freeze"].ToString(), dr["invite"].ToString(), dr["count"].ToString(), dr["Last_paid"].ToString(), dr["Remaind"].ToString());
                flowLayoutPanel1.Controls.Add(us);
            }
            dr.Close();
            Member.con.Close();
        }

        private void conusers_btn_Click(object sender, EventArgs e)
        {
            string start;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(panel2);

            cmd = new SqlCommand("Select * from member", Member.con);
            Member.con.Open();
            dr = cmd.ExecuteReader();
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
                    us.put(dr["ID"].ToString(), dr["Name"].ToString(), dr["Term"].ToString(), dr["Phone"].ToString(), start, dr["end_date_outfreeze"].ToString(), dr["Freeze"].ToString(), dr["invite"].ToString(), dr["count"].ToString(), dr["Last_paid"].ToString(), dr["Remaind"].ToString());
                    flowLayoutPanel1.Controls.Add(us);
                }
            }
            dr.Close();
            Member.con.Close();
        }

        private void endedusers_btn_Click(object sender, EventArgs e)
        {

            string start;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(panel2);
            cmd = new SqlCommand("Select * from member", Member.con);
            Member.con.Open();
            dr = cmd.ExecuteReader();
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
                        us.put(dr["ID"].ToString(), dr["Name"].ToString(), dr["Term"].ToString(), dr["Phone"].ToString(), start, dr["end_date_outfreeze"].ToString(), dr["Freeze"].ToString(), dr["invite"].ToString(), dr["count"].ToString(), dr["Last_paid"].ToString(), dr["Remaind"].ToString());
                        flowLayoutPanel1.Controls.Add(us);
                    }    
            }
            dr.Close();
            Member.con.Close();

        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search_btn_Click(sender, e);
            }
        }

        private void repay_btn_Click(object sender, EventArgs e)
        {
            repay_box.Show();
            repay_btn.Hide();
            remin_txt.Text = search1.R_txt.Text;
        }
        public static int M_ID = 0;
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            bool x = search_txt.Text.All(char.IsDigit);
            bool flag = paid_txt.Text.All(char.IsDigit);
            if (paid_txt.Text == "")
                MessageBox.Show("Please enter the paid amount !\n من فضلك أدخل المبلغ المدفوع!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!flag || Convert.ToInt16(paid_txt.Text) > Convert.ToInt16(search1.R_txt.Text))
                MessageBox.Show("Please make sure of the amount paid!\n  من فضلك تأكد من المبلغ المدفوع!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (x)
                {
                    if (M.Check_exist(Convert.ToInt32(search_txt.Text)))
                        M_ID = Convert.ToInt32(search_txt.Text);
                }
                else
                {
                    cmd = new SqlCommand("Select ID from member where Name ='" + search_txt.Text + "' ", Member.con);
                    Member.con.Open();
                    dr = cmd.ExecuteReader();
                    if (M.Check_exist_name(search_txt.Text))
                        if (dr.Read())
                            M_ID = Convert.ToInt16(dr.ToString());
                    Member.con.Close();
                }
                cmd = new SqlCommand("Update member set Last_paid='" + Convert.ToInt16(paid_txt.Text) + "', Remaind='" + Convert.ToInt16(remin_txt.Text) + "' where ID='" + M_ID + "'", Member.con);
                Member.con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Debt paid successfully!", "Done :)", MessageBoxButtons.OK);
                repay_box.Hide();
                paid_txt.Clear();
                Member.con.Close();
            }
        }

        private void paid_txt_TextChanged(object sender, EventArgs e)
        {
            if (paid_txt.Text != "" && paid_txt.Text.All(char.IsDigit))
            {
                if (Convert.ToInt16(search1.R_txt.Text) < Convert.ToInt16(paid_txt.Text))
                    remin_txt.Text = "-";
                else
                {
                    int R = Convert.ToInt16(search1.R_txt.Text) - Convert.ToInt16(paid_txt.Text);
                    remin_txt.Text = R.ToString();
                }
            }
            else if (paid_txt.Text == "")
                remin_txt.Text = search1.R_txt.Text;
             


        }
    }
}
