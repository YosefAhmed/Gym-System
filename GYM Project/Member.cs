using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

struct Date
{
    int Day, Month,Year;
};
namespace GYM_Project
{
    class Member
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True ");
        SqlCommand cmd;

        //public Full_Name Name { get; set; }
        //public int M_ID { get; set; }
        //public int   Term { get; set; }
        //public Date Start_date { get; set; }
        //public DateTime Expir { get; set; }
        //public int Phone { get; set; }
        //public int Freeze { get; set; }
        //public int Invitation { get; set; }
        public int M_ID { get; set; }
        public Date Expir { get; set; }
        public int Start_day { get; set; }
        public int Start_mon { get; set; }
        public int Start_year { get; set; }
        public string Phone { get; set; }
        public int Freeze { get; set; }
        public int Invitation { get; set; }
        public string end_date { get; set; }


        public void Insert_new(string name,int Id,int term,Date date,int phone)//Collectes & Inserts Data Into DB
        {
        }

        public void Check(int Id)//checkes if ID is existed & if membership is available
        {
            con.Open();
            cmd = new SqlCommand("select End_day,End_month,End_year from member where ID='" + Id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();

            if (RD.Read())
            {
                int year, month, day = Convert.ToInt32(RD["End_day"].ToString());
                month = Convert.ToInt32(RD["End_month"].ToString());
                year = Convert.ToInt32(RD["End_year"].ToString());


                DateTime Start=new DateTime(year,day,month);
                if (DateTime.Today<= Start)
                    MessageBox.Show("Loged In Successfully !", "Succeeded !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    MessageBox.Show("Membership Ended!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Do You Wont To Renew The Membership?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }
            else if (!RD.Read())
                MessageBox.Show("Member Not Exist !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
        }



        public void search_ID(int Id)//searches for some ID
        {

        }
        public void search_Name(string name)//searches for some Name
        {

        }
        public void renew(Date date)//updates the start date & the term
        {

        }
        public void freeze(int legnth,Date date)//updates the expir date **(this function may be removed)**
        {

        }
        public void Cancel_freeze(int legnth, Date date)//updates the expir date **(this function may be removed)**
        {

        }
        public void invite(int id)//updates the number of invitations  **(this function may be removed)**
        {

        }
        public void  delete(int id)//deletes all information of the member
        {

        }


    }
}
