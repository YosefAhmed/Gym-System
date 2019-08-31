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


        private void Add_member_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void calcbtn_Click(object sender, EventArgs e)
        {
            
                

        }
        public static string edate;
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
            string s = in_pho.Text;
            bool x = in_pho.Text.All(char.IsDigit);
            if (in_name.Text == "" || in_pho.Text == "" /*|| in_id.Text == ""*/ || iday.Text == "Day" || imonth.Text == "Mon" || iyear.Text == "Year" || ((ishr.Checked == false && i3shr.Checked == false && i6shr.Checked == false && isna.Checked == false)))
            {
                MessageBox.Show("Please enter all data !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
            else if(in_pho.Text.Length!=11 || !x || s[0]!='0' || s[1]!='1'  ){
                  MessageBox.Show("Phone number is not correct !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                m.Insert_new(in_name.Text, term,Convert.ToString( d.Year + "-" + d.Month + "-" + d.Day ), edate,in_pho.Text);
                this.Close();
            }
        }
            private void iyear_Click(object sender, EventArgs e)
            {
                
            }

            private void imonth_Click(object sender, EventArgs e)
            {
                
            }

            private void iday_Click(object sender, EventArgs e)
            {
                
            }
        
        private void in_id_Click(object sender, EventArgs e)
        {
            Member.GetMembers();
            in_id.Text = (Member.membersdata.Count+100).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void in_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void in_id_Enter(object sender, EventArgs e)
        {
           
        }
    }
    }

