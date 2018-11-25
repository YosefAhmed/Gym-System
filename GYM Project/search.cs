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
    public partial class search : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5JMJ2DN\SQLEXPRESS;Initial Catalog=test 1 gym;Integrated Security=True");
        SqlDataAdapter Da;
        DataSet Ds = new DataSet();
        SqlCommand cmd;
        SqlDataReader dr;
        public search()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        //    cmd = new SqlCommand("select * from test1gym where id='" + Convert.ToInt32(textBox5.Text) + "'", con);
        //    con.Open();
        //    dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        textBox1.Text = dr.GetValue(0).ToString();
        //        textBox2.Text = dr.GetValue(1).ToString();
        //        textBox3.Text = dr.GetValue(9).ToString();
        //        textBox4.Text = dr.GetValue(10).ToString();
        //    }
        //    else
        //    {
        //        textBox1.Text = "";
        //        textBox2.Text = "";
        //        textBox3.Text = "";
        //        textBox4.Text = "";
        //        textBox5.Text = "";
        //        MessageBox.Show("Member Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    con.Close();
        }

        private void search_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show(Member.t2);
            Member m = new Member();
            //textBox1.Text = Member.t1;
            //textBox2.Text = Member.t2;
            //textBox3.Text = Member.t3;
            //textBox4.Text = Member.t4;
        }
    }
}
