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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IAQJRV6\SQLEXPRESS;Initial Catalog=Gym_;Integrated Security=True");
        SqlCommand cmd;
        public Admin_Settings()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Year_txt.Text == "" || Six_M_txt.Text == "" || three_M_txt.Text == "" || one_M_txt.Text == "")
            {
                MessageBox.Show("Please enter all data !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            cmd = new SqlCommand("Update Price set Price_1Y='"+Year_txt.Text+"', Price_6M='"+Six_M_txt.Text+"', Price_3M='"+three_M_txt.Text+"', Price_1M='"+one_M_txt.Text+"'where ID='"+1+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
                MessageBox.Show("All prices are updated :)");
            con.Close();
            Main F = new Main();
            F.Show();
            ParentForm.Hide();
            }
        }

        private void Admin_Settings_Load(object sender, EventArgs e)
        {

        }


    }
}
