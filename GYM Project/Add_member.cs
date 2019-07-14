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
        public string return_price(string period)
        {
            cmd = new SqlCommand("select *from Price", Member.con);
            Member.con.Open();
            RD = cmd.ExecuteReader();
            if (RD.Read())
            {
                if (period == "ishr")
                {
                    period = RD["Price_1M"].ToString();
                }
                else if (period == "i3shr")
                {
                    period = RD["Price_3M"].ToString();
                }
                else if (period == "i6shr")
                {
                    period = RD["Price_6M"].ToString();
                }
                else if (period == "isna")
                {
                    period = RD["Price_1Y"].ToString();
                }
            }
            RD.Close();
            Member.con.Close();
            return period;
        }
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
        Member M = new Member();
        SqlCommand cmd;
        SqlDataReader RD;
        private void calcbtn_Click(object sender, EventArgs e)
        {
            bool flag = paid_txt.Text.All(char.IsDigit);
            if (ishr.Checked || i3shr.Checked || i6shr.Checked || isna.Checked)
            {
                if (paid_txt.Text == "")
                    MessageBox.Show("Please enter all data !\n من فضلك املأ جميع البيانات!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!flag || Convert.ToInt16(paid_txt.Text) > Convert.ToInt16(pricetxt.Text))
                    MessageBox.Show("Please make sure of the amount paid!\n  من فضلك تأكد من المبلغ المدفوع!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int R = Convert.ToInt16(pricetxt.Text) - Convert.ToInt16(paid_txt.Text);
                    remin_txt.Text = R.ToString();
                }
            }
            else
                MessageBox.Show("Please check a membership term !\nمن فضلك اختر فترة اشتراك! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public static string edate,remind_tmp,paid_tmp;
        public void calc_renew(string day, int mon, string year)//calc end date with freeze
        {

            DateTime d = new DateTime(Convert.ToInt32(year), mon, Convert.ToInt32(day));

            //dah l 4hr
            if (ishr.Checked)
            {
                TimeSpan T = TimeSpan.FromDays(30);
                DateTime ed = d.Add(T);
                edate = ed.ToShortDateString();
            }
            ///////////////////////////////////////////////
            //dah l 3 4hor
            if (i3shr.Checked)
            {
                TimeSpan T = TimeSpan.FromDays(90);
                DateTime ed = d.Add(T);
                edate = ed.ToShortDateString();
            }
            //////////////////////////////////////////////////////
            //dah l 6 4hor
            if (i6shr.Checked)
            {
                
                TimeSpan T = TimeSpan.FromDays(180);
                DateTime ed = d.Add(T);
                edate = ed.ToShortDateString();
            }
            //////////////////////////////////////////////////
            //dah l sna
            if (isna.Checked)
            {
                TimeSpan T = TimeSpan.FromDays(365);
                DateTime ed = d.Add(T);
                edate = ed.ToShortDateString();
            }
        }
        public static string term;
        public static int f;
        public static int invite;
        public static int count;
        private void button1_Click(object sender, EventArgs e)
        {
            int freeze_sna=0; int freeze_6=0; int freeze_3=0; int freeze_1=0;      
            cmd = new SqlCommand("select *from Price", Member.con);
            Member.con.Open();
            RD = cmd.ExecuteReader();
            while (RD.Read())
            {
                 freeze_sna = RD.GetInt32(5);
                 freeze_6 = RD.GetInt32(6);
                 freeze_3 = RD.GetInt32(7);
                freeze_1 = RD.GetInt32(8);
            }
            RD.Close();
            Member.con.Close();



            string s = in_pho.Text;
            bool x = in_pho.Text.All(char.IsDigit);
            if (paid_txt.Text==""||in_name.Text == "" || in_pho.Text == "" || in_id.Text == "" || iday.Text == "Day" || imonth.Text == "Mon" || iyear.Text == "Year" || ((ishr.Checked == false && i3shr.Checked == false && i6shr.Checked == false && isna.Checked == false)))
                  MessageBox.Show("Please enter all data !\n من فضلك املأ جميع البيانات!", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else if(in_pho.Text.Length!=11 || !x || s[0]!='0' || s[1]!='1'  )
                  MessageBox.Show("Phone number is invalid !\n !رقم الهاتف غير صالح", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                name = in_name.Text;
                phone = in_pho.Text;
                calc_renew(iday.Text, Convert.ToInt32(imonth.Text), iyear.Text);
                
                if (ishr.Checked == true)
                {
                    term = ishr.Text;
                    f =freeze_1 ;
                    invite = 0;
                    count = 30;
                }
                else if (i3shr.Checked == true)
                {
                    term = i3shr.Text;
                    f = freeze_3;
                    invite = 6;
                    count = 90;
                }
                else if (i6shr.Checked == true)
                {
                    term = i6shr.Text;
                    f = freeze_6;
                    invite = 12;
                    count = 180;
                }
                else if (isna.Checked == true)
                {
                    term = isna.Text;
                    f = freeze_sna;
                    invite = 25;
                    count = 365;
                }
                Date d;
                d.Day = Convert.ToInt32(iday.Text);
                d.Month = Convert.ToInt32(imonth.Text);
                d.Year = Convert.ToInt32(iyear.Text);
                if (remin_txt.Text.All(char.IsDigit))
                {
                    remind_tmp = remin_txt.Text;
                    paid_tmp = paid_txt.Text;
                    M.Insert_new(in_name.Text, term, d.Day, d.Month, d.Year, in_pho.Text, edate);
                    this.Close();
                }
                else
                    MessageBox.Show("Please press 'Calculate' button before conferm !\nمن فضلك احسب المبلغ الباقي قبل تأكيد الاشتراك !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public int MAX;
        private void in_id_Click(object sender, EventArgs e)
        {
            MAX = 0;
            int g;
            Member.con.Open();
            cmd = new SqlCommand("Select ID from member", Member.con);
            RD = cmd.ExecuteReader();

            while (RD.Read())
            {
                g = Convert.ToInt32((RD["ID"].ToString()));
                if (g >= MAX)
                { MAX = g; }
            }


            RD.Close();
             Member.con.Close();
            if (MAX == 0)
            { in_id.Text = "1000"; }
            else
                in_id.Text = (MAX + 1).ToString();
        }
        private void in_id_Enter(object sender, EventArgs e)
        {
            MAX = 0;
            int g;
            Member.con.Open();
             cmd = new SqlCommand("Select ID from member", Member.con);
             RD = cmd.ExecuteReader();

            while (RD.Read())
            {
                g = Convert.ToInt32((RD["ID"].ToString()));
                if (g >= MAX)
                { MAX = g; }
            }


            RD.Close();
            Member.con.Close();
            if (MAX == 0)
            { in_id.Text = "1000"; }
            else
                in_id.Text = (MAX + 1).ToString();
        }

        private void ishr_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text = return_price(ishr.Name);
            if (paid_txt.Text != "")
                calcbtn_Click(sender,e);
        }

        private void i3shr_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text = return_price(i3shr.Name);
            if (paid_txt.Text != "") 
                calcbtn_Click(sender, e);
        }  

        private void i6shr_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text = return_price(i6shr.Name);
            if (paid_txt.Text != "")
                calcbtn_Click(sender, e);
        }

        private void isna_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text = return_price(isna.Name);
            if (paid_txt.Text != "")
                calcbtn_Click(sender, e);
        }


    }
    }

