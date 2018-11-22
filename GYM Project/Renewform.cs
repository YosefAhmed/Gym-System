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
        public void calc_renew(string day, int mon, string year)//calc end date with freeze
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
                if (editedmon < 9 && Convert.ToInt32(d) <= 16)
                {
                    editedmon += 3;
                    mf += 3;
                    d += 15;
                    // y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon < 9 && Convert.ToInt32(d) > 16)
                {
                    editedmon += 4;
                    mf += 3;
                    d = d - 15;
                    //y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon == 9 && Convert.ToInt32(d) <= 16)
                {
                    editedmon += 3;
                    mf += 3;
                    d += 15;
                    // y = Convert.ToInt32(isna.Text);
                }
                else if (editedmon == 9 && Convert.ToInt32(d) > 16)
                {
                    editedmon = 1;
                    mf += 3;
                    d = d - 15;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 10 && Convert.ToInt32(d) <= 16)
                {
                    editedmon = 1;
                    mf = 1;
                    d = d + 15;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 10 && Convert.ToInt32(d) > 16)
                {
                    editedmon = 2;
                    mf = 1;
                    d = d - 15;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 11 && Convert.ToInt32(d) <= 16)
                {
                    editedmon = 2;
                    mf = 2;
                    d = d + 15;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 11 && Convert.ToInt32(d) > 16)
                {
                    editedmon = 3;
                    mf = 2;
                    d = d - 15; 
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 12 && Convert.ToInt32(d) <= 16)
                {
                    editedmon = 3;
                    mf = 3;
                    d = d + 15;
                    yf++;
                    y = y + 1;
                }
                else if (editedmon == 12 && Convert.ToInt32(d) > 16)
                {
                    editedmon = 4;
                    mf += 3;
                    d = d - 15;
                    yf++;
                    y = y + 1;
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
                    mf = 1;
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
                    y = y + 1;
                }
                else if (editedmon == 12)
                {
                    editedmon = 7;
                    mf = 6;
                    yf++;
                    y = y + 1;
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
            end_d = df.ToString() + "/" + mf.ToString() + "/" + yf.ToString();
            end_date_outfr = df.ToString() + "/" + mf.ToString() + "/" + yf.ToString();
           
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
            me.renew(Convert.ToInt32(in_id.Text), term, df, mf, yf, end_d, end_date_outfr, f, invite, count);
            this.Close();
        }
    }
}
