using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Project
{
    public partial class Renewform : Form
    {
        public Renewform()
        {
            InitializeComponent();
        }

        private void Renewform_Load(object sender, EventArgs e)
        {
            in_id.Text = Member.re_id.ToString();
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
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            calc_renew(DateTime.Today.Day.ToString(),DateTime.Today.Month, DateTime.Today.Year.ToString());
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
            Member me = new Member();
            me.renew(Convert.ToInt32(in_id.Text), term, edate, f, invite, count);
            this.Close();
        }
    }
}
