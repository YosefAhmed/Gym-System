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

namespace GYM_Project
{
    public partial class Add_member : Form
    {
        public Add_member()
        {
            InitializeComponent();
        }
        public struct Date
        {
            public int Day, Month, Year;
        };
        public static string name;
        public static int id;
        public static string phone;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");

        private void Add_member_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

            public int calc;
        private void calcbtn_Click(object sender, EventArgs e)
        {
            if (pricetxt.Text == "")
            {
                ishr.Focus();
            }
            else
            {
                calc = Convert.ToInt32(pricetxt.Text);
                if (ishr.Checked == true)
                {
                    pricetxt.Text = calc.ToString();
                }
                else if (i3shr.Checked == true)
                {
                    calc = calc * 3;
                    pricetxt.Text = calc.ToString();
                }
                else if (i6shr.Checked == true)
                {
                    calc = calc * 6;
                    pricetxt.Text = calc.ToString();
                }
                else if (isna.Checked == true)
                {
                    calc = calc * 12;
                    pricetxt.Text = calc.ToString();
                }
            }

        }
        public static int d;
        public int m;
        public static int y;
        public static int editedmon;

        public static string end_d;

        public void calc_end(string day,int mon,string year)
        {
            editedmon = mon;
            d = Convert.ToInt32(day);
            y = Convert.ToInt32(year);
            //dah l 4hr
            if (ishr.Checked)
            {
                if (editedmon == 12)
                {
                    editedmon = 1;
                    //d = Convert.ToInt32(iday.Text);
                    y++;
                }
                else
                {
                    editedmon += 1;
                    //d = Convert.ToInt32(iday.Text);
                    //y = Convert.ToInt32(isna.Text);
                }
            }
            ///////////////////////////////////////////////
            //dah l 3 4hor
            if (i3shr.Checked)
            {
                if (editedmon < 9 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon += 3;
                    d += 15;
                   // y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon < 9 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon += 4;
                    d = d - 15;
                    //y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon == 9 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon += 3;
                    d += 15;
                   // y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon == 9 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 1;
                    d =d- 15;
                    y = y + 1;
                }
                else if (editedmon == 10 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon = 1;
                    d = d + 15;
                    y = y + 1;
                }
                else if (editedmon == 10 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 2;
                    d = d - 15;
                    y = y + 1;
                }
                else if (editedmon == 11 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon = 2;
                    d = d + 15;
                    y = y + 1;
                }
                else if (editedmon == 11 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 3;
                    d = d- 15;
                    y = y+ 1;
                }
                else if (editedmon == 12 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon = 3;
                    d = d + 15;
                    y = y + 1;
                }
                else if (editedmon == 12 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 4;
                    d = d- 15;
                    y = y+ 1;
                }
            }
            //////////////////////////////////////////////////////
            //dah l 6 4hor
            if (i6shr.Checked)
            {
                if (editedmon <= 5)
                {
                    editedmon += 7;
                    //d = Convert.ToInt32(iday.Text);
                    //y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon == 6)
                {
                    editedmon = 1;
                   // d = Convert.ToInt32(iday.Text);
                    y = y + 1;
                }
                else if (editedmon == 7)
                {
                    editedmon = 2;
                   // d = Convert.ToInt32(iday.Text);
                    y = y + 1;
                }
                else if (editedmon == 8)
                {
                    editedmon = 3;
                    //d = Convert.ToInt32(iday.Text);
                    y = y + 1;
                }
                else if (editedmon == 9)
                {
                    editedmon = 4;
                   // d = Convert.ToInt32(iday.Text);
                    y = y + 1;
                }
                else if (editedmon == 10)
                {
                    editedmon = 5;
                    //d = Convert.ToInt32(iday.Text);
                    y = y + 1;
                }
                else if (editedmon == 11)
                {
                    editedmon = 6;
                   // d = Convert.ToInt32(iday.Text);
                    y =y+ 1;
                }
                else if (editedmon == 12)
                {
                    editedmon = 7;
                   // d = Convert.ToInt32(iday.Text);
                    y = y+ 1;
                }
            }
            //////////////////////////////////////////////////
            //dah l sna
            if (isna.Checked)
            {
                if (editedmon == 11)
                {
                    editedmon = 1;
                    //d = Convert.ToInt32(iday.Text);
                    y = y + 2;
                }
                else if (editedmon == 12)
                {
                    editedmon = 2;
                   // d = Convert.ToInt32(iday.Text);
                    y = y + 2;
                }
                else
                {

                    editedmon += 2;
                    //d = Convert.ToInt32(iday.Text);
                    y = y + 1;
                }
            }
            end_d = d.ToString() + "/" + editedmon.ToString() + "/" + y.ToString();
        }
        public static string term;
        public static int f;
        public static int invite;
        public static int count;
        private void button1_Click(object sender, EventArgs e)
        {
            if (in_name.Text == "" || in_pho.Text == "" || in_id.Text == "" || iday.Text == "Day" || imonth.Text == "Mon" || iyear.Text == "Year" || ((ishr.Checked == false && i3shr.Checked == false && i6shr.Checked == false && isna.Checked == false)))
            {
                MessageBox.Show("Please enter all data !! ");
            }
            else
            {
                Member m = new Member();
                name = in_name.Text;
                //id = Convert.ToInt32(in_id.Text);
                phone = in_pho.Text;
                calc_end(iday.Text, Convert.ToInt32(imonth.Text), iyear.Text);

                if (ishr.Checked == true)
                {
                    term = ishr.Text;
                    f = 0;
                    invite = 0;
                    count = 30;
                }
                else if (i3shr.Checked == true)
                {
                    term = i3shr.Text;
                    f = 15;
                    invite = 6;
                    count = 90;
                }
                else if (i6shr.Checked == true)
                {
                    term = i6shr.Text;
                    f = 30;
                    invite = 12;
                    count = 180;
                }
                else if (isna.Checked == true)
                {
                    term = isna.Text;
                    f = 60;
                    invite = 25;
                    count = 365;
                }
                Date d;
                d.Day = Convert.ToInt32(iday.Text);
                d.Month = Convert.ToInt32(imonth.Text);
                d.Year = Convert.ToInt32(iyear.Text);
                m.Insert_new(in_name.Text, term, d.Day, d.Month, d.Year, in_pho.Text);

            }
        }
            private void iyear_Click(object sender, EventArgs e)
            {
                label18.Hide();
            }

            private void imonth_Click(object sender, EventArgs e)
            {
                label19.Hide();
            }

            private void iday_Click(object sender, EventArgs e)
            {
                label20.Hide();
            }
        public int MAX;
        private void in_id_Click(object sender, EventArgs e)
        {
            MAX = 0;
            int g;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID from member", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                g = Convert.ToInt32((dr["ID"].ToString()));
                if (g >= MAX)
                { MAX = g; }
            }

            con.Close();
            dr.Close();
            if (MAX == 0)
            { in_id.Text = "1"; }
            else
                in_id.Text = (MAX + 1).ToString();
        }
    }
    }

