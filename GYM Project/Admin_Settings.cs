using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYM_Project
{
    public partial class Admin_Settings : UserControl
    {
        Member M = new Member();
        SqlCommand cmd;
        SqlDataReader rd;
        public Admin_Settings()
        {
            InitializeComponent();
            Save_btn.Focus();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Year_txt.Text == "" || Six_M_txt.Text == "" || three_M_txt.Text == "" || one_M_txt.Text == "" || frez_y.Text=="" || frez_6M.Text=="" || frez_3M.Text=="" ||frez_1M.Text=="")
            {
                MessageBox.Show("Please enter all data !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new SqlCommand("Update Price set Price_1Y='" + Year_txt.Text + "', Price_6M='" + Six_M_txt.Text + "', Price_3M='" + three_M_txt.Text + "', Price_1M='" + one_M_txt.Text + "',freeze_Y='" + frez_y.Text + "',freeze_6M='" + frez_6M.Text + "',freeze_3M='" +frez_3M.Text+ "',freeze_1M='"+frez_1M.Text+"'where ID='" + 1 + "'", M.con);
            M.con.Open();
            cmd.ExecuteNonQuery();
                MessageBox.Show("All settings are updated :)");
            M.con.Close();
            Main F = new Main();
            F.Show();
            ParentForm.Hide();
            }
        }

        private void Admin_Settings_Load(object sender, EventArgs e)
        {   
            cmd = new SqlCommand("select *from Price",M.con);
            M.con.Open();
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                Year_txt.Text = rd.GetSqlInt32(1).ToString();
                Six_M_txt.Text = rd.GetSqlInt32(2).ToString();
                three_M_txt.Text = rd.GetSqlInt32(3).ToString();
                one_M_txt.Text = rd.GetSqlInt32(4).ToString();
                frez_y.Text = rd.GetSqlInt32(5).ToString();
                frez_6M.Text = rd.GetSqlInt32(6).ToString();
                frez_3M.Text = rd.GetSqlInt32(7).ToString();
                frez_1M.Text = rd.GetSqlInt32(8).ToString();
            }
            rd.Close();
            M.con.Close();
            
        }


    }
}
