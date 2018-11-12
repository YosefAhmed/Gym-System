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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        SqlCommand cmd;
        public Admin_Settings()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Admin (Admin_ID, Admin_Pass, Price_1Y, Price_6M, Price_3M, Price_1M)values(123,123,'" + Year_txt.Text + "','" + Six_M_txt.Text + "','" + three_M_txt.Text + "','" + one_M_txt.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Form1 F = new Form1();
            F.Show();
            ParentForm.Hide();
        }


    }
}
