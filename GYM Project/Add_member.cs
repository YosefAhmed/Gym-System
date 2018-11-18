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

        SqlConnection con = new SqlConnection(@"Data Source=Yousef;Initial Catalog=Gym_;Integrated Security=True");

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
        //////////////// variables for calc end with freeze 
        public static int d;
        public int m;
        public static int y;
        public static int editedmon;
        public static string end_d;
        ///////////////Variables for calc end without freeze
        public static int df;
        public static int mf;
        public static int yf;
        public static string end_date_outfr;
        public void calc_renew(string day,int mon,string year)//calc end date with freeze
        {
            editedmon = mon;
            d = Convert.ToInt32(day);
            y = Convert.ToInt32(year);
            mf = editedmon;
            df = d;
            yf = y;
            //dah l 4hr
            if (ishr.Checked)
            {
                if (editedmon == 12)
                {
                    editedmon = 1;
                    mf = 1;
                    yf++;
                    y++;
                }
                else
                {
                    editedmon += 1;
                    mf++;
                }
            }
            ///////////////////////////////////////////////
            //dah l 3 4hor
            if (i3shr.Checked)
            {
                if (editedmon < 9 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon += 3;
                    mf += 3;
                    d += 15;
                   // y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon < 9 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon += 4;
                    mf += 3;
                    d = d - 15;
                    //y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon == 9 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon += 3;
                    mf += 3;
                    d += 15;
                   // y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon == 9 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 1;
                    mf += 3;
                    d =d- 15;
                    y = y + 1;
                }
                else if (editedmon == 10 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon = 1;
                    mf = 1;
                    d = d + 15;
                    y = y + 1;
                }
                else if (editedmon == 10 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 2;
                    mf = 1;
                    d = d - 15;
                    y = y + 1;
                }
                else if (editedmon == 11 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon = 2;
                    mf = 2;
                    d = d + 15;
                    y = y + 1;
                }
                else if (editedmon == 11 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 3;
                    mf = 2;
                    d = d- 15;
                    y = y+ 1;
                }
                else if (editedmon == 12 && Convert.ToInt32(iday.Text) <= 16)
                {
                    editedmon = 3;
                    mf = 3;
                    d = d + 15;
                    y = y + 1;
                }
                else if (editedmon == 12 && Convert.ToInt32(iday.Text) > 16)
                {
                    editedmon = 4;
                    mf += 3;
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
                    mf += 6;
                }
                else if (editedmon == 6)
                {
                    editedmon = 1;
                    mf = 12;
                    y = y + 1;
                }
                else if (editedmon == 7)
                {
                    editedmon = 2;
                    mf=1;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 8)
                {
                    editedmon = 3;
                    mf = 2;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 9)
                {
                    editedmon = 4;
                    mf = 3;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 10)
                {
                    editedmon = 5;
                    mf = 4;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 11)
                {
                    editedmon = 6;
                    mf = 5;
                    yf++;
                    y =y+ 1;
                }
                else if (editedmon == 12)
                {
                    editedmon = 7;
                    mf = 6;
                    yf++;
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
                    mf = 11;
                    yf++;
                    y = y + 2;
                }
                else if (editedmon == 12)
                {
                    editedmon = 2;
                    yf = 12;
                    yf++;
                    y = y + 2;
                }
                else
                {

                    editedmon += 2;
                    yf++;
                    y = y + 1;
                }
            }
            end_d = d.ToString() + "/" + editedmon.ToString() + "/" + y.ToString();
            end_date_outfr = df.ToString() + "/" + mf.ToString() + "/" + yf.ToString();
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
                calc_renew(iday.Text, Convert.ToInt32(imonth.Text), iyear.Text);

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
                this.Close();
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


            dr.Close();
             con.Close();
            if (MAX == 0)
            { in_id.Text = "1000"; }
            else
                in_id.Text = (MAX + 1).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void in_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

