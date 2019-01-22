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
        Member M = new Member(); 
        public static string edate;
        SqlCommand cmd;
        SqlDataReader rd;
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
            int freeze_sna = 0; int freeze_6 = 0; int freeze_3 = 0; int freeze_1 = 0;
            if (paid_txt.Text == "")
                MessageBox.Show("Please enter the paid amount !\n من فضلك أدخل المبلغ المدفوع!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {     

                cmd = new SqlCommand("select *from Price", M.con);
                M.con.Open();
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    freeze_sna = rd.GetInt32(5);
                    freeze_6 = rd.GetInt32(6);
                    freeze_3 = rd.GetInt32(7);
                    freeze_1 = rd.GetInt32(8);
                }
                rd.Close();
                M.con.Close();

                calc_renew(DateTime.Today.Day.ToString(), DateTime.Today.Month, DateTime.Today.Year.ToString());
                if (ishr.Checked == true)
                {
                    term = ishr.Text;
                    f = freeze_1;
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
                if (remin_txt.Text.All(char.IsDigit))
                {
                    Add_member.remind_tmp = remin_txt.Text;
                    Add_member.paid_tmp = paid_txt.Text;
                    M.renew(Convert.ToInt32(in_id.Text), term, edate, f, invite, count);
                    this.Close();
                }
                else
                    MessageBox.Show("Please press 'Calculate' button before conferm !\nمن فضلك احسب المبلغ الباقي قبل تأكيد الاشتراك !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            bool flag = paid_txt.Text.All(char.IsDigit);

            if (ishr.Checked || i3shr.Checked || i6shr.Checked || isna.Checked)
            {
                if (paid_txt.Text == "")
                    MessageBox.Show("Please enter the paid amount !\n من فضلك أدخل المبلغ المدفوع!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        Add_member A = new Add_member();
        private void ishr_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text =A.return_price(ishr.Name);
            if (paid_txt.Text != "")
                calcbtn_Click(sender, e);
        }

        private void i3shr_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text = A.return_price(i3shr.Name);
            if (paid_txt.Text != "")
                calcbtn_Click(sender, e);
        }

        private void i6shr_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text = A.return_price(i6shr.Name);
            if (paid_txt.Text != "")
                calcbtn_Click(sender, e);
        }

        private void isna_CheckedChanged(object sender, EventArgs e)
        {
            pricetxt.Text = A.return_price(isna.Name);
            if (paid_txt.Text != "")
                calcbtn_Click(sender, e);
        }
    }
}
