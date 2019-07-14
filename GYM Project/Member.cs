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
using System.Globalization;
public struct Date
{
    public int Day, Month,Year;
};

namespace GYM_Project
{
    class Member
    {
        public string M_ID { get; set; }
        public string M_Name { get; set; }
        public int Freeze { get; set; }
        public int Invitation { get; set; }
        public int remaind { get; set; }
        public int paid { get; set; }

        public SqlConnection con = new SqlConnection(@"Data Source=yousef\YOUSEF;Initial Catalog=Gym_;Integrated Security=True");
        SqlCommand cmd;
        public void Insert_new(string insert_name, string Term, int Start_day, int Start_mon, int Start_year, String phone, string ed)//Collectes & Inserts Data Into DB
        {
            Add_member add = new Add_member();
            Freeze = Add_member.f;
            Invitation = Add_member.invite;
            remaind = Convert.ToInt16(Add_member.remind_tmp);
            paid = Convert.ToInt16(Add_member.paid_tmp);
            DialogResult result = MessageBox.Show("Do you want to confirm your subscription for Mr:" + insert_name + " ??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("DECLARE @maxVal INT SELECT @maxVal = ISNULL(max(ID),999) from member  DBCC CHECKIDENT('member', RESEED, @maxVal)    insert into member(Name,Term,Phone,Start_day,Start_month,Start_year,end_date_outfreeze,Freeze,invite,count,Remaind,Last_paid)values (N'" + insert_name + "',N'" + Term + "',N'" + phone + "','" + Start_day + "','" + Start_mon + "','" + Start_year + "','" + ed + "','" + Freeze + "','" + Invitation + "','" + Add_member.count + "','" + remaind + "','" + paid + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data is recorded for Mr : " + insert_name + "\nEnd date is : " + ed + "\nInvitaions : " + Invitation + "\nFreeze : " + Freeze + "\nPaid Amount: " + paid + "\nRemaining Amount: " + remaind, "Done :)", MessageBoxButtons.OK);
            }
        }
        public bool Check_exist(int Id)
        {
            con.Open();
            cmd = new SqlCommand("select * from member where ID='" + Id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();

            if (!RD.Read())
            {
                MessageBox.Show("Member Not Exist !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }

            else
            {
                con.Close();
                return true;
            }

        }
        public bool Check_exist_name(string name)
        {
            con.Open();
            cmd = new SqlCommand("select * from member where Name='" + name + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();

            if (!RD.Read())
            {
                MessageBox.Show("Member Not Exist !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }

            else
            {
                con.Close();
                return true;
            }

        }
        public static int re_id;
        public void Check(int Id)//checkes if ID is existed & if membership is available
        {

            con.Open();
            cmd = new SqlCommand("select * from member where ID='" + Id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();


            if (RD.Read())
            {
                string End = RD["end_date_outfreeze"].ToString();
                int c = Convert.ToInt32(RD["count"]);
                string name = RD["Name"].ToString();
                // string endd = RD["end_date_outfreeze"].ToString();
                DialogResult resu = MessageBox.Show("Name : " + name + '\n' + "you still have " + RD["Freeze"] + " freeze days and " + RD["invite"] + " invitations " + '\n' + "till : " + End, "Do you want to login with this details ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                RD.Close();
                if (resu == DialogResult.Yes)
                {
                    // DateTime En = new DateTime(year, month, day);
                    string[] format = { "yyyy-MM-dd" };
                    DateTime Sdate;
                    DateTime.TryParseExact(End.ToString(), format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out Sdate);

                    if (DateTime.Today > Sdate || c <= 0)
                    {
                        MessageBox.Show("Membership Ended for Mr : " + name + " :( ", "We are sorry for this :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DialogResult res = MessageBox.Show("Do You Wont To Renew The Membership ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        re_id = Id;
                        if (res == DialogResult.Yes)
                        {
                            Renewform r = new Renewform();
                            Login l = new Login();
                            l.Hide();
                            r.Show();
                        }
                    }
                    else if (DateTime.Today <= Convert.ToDateTime(End) && c > 0)
                    {
                        MessageBox.Show("Loged In Successfully !", "Succeeded !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        c--;
                        cmd = new SqlCommand("Update member set count='" + c + "'where ID='" + Id + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

            }
            else if (!RD.Read())
                MessageBox.Show("Member Not Exist !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
            RD.Close();
        }
        public string m_id;
        public string m_name;
        public string num_invit;
        public string num_freez;

        public void search_ID(int Id)//searches for some ID
        {
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand("select * from member where ID='" + Id + "'or Name='" + Id + "'", con);
            con.Close();
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Here we are putting data readed from DB into the members of the class to call it in the search form
                M_ID = dr["ID"].ToString();
                M_Name = dr["Name"].ToString();
                num_invit = dr["Freeze"].ToString();
                num_freez = dr["invite"].ToString();
                Freeze = Convert.ToInt32(num_invit);
                Invitation = Convert.ToInt32(num_freez);
                remaind = Convert.ToInt32(dr["Remaind"].ToString());
                paid = Convert.ToInt32(dr["Last_paid"].ToString());

            }
            dr.Close();
            con.Close();
        }
        public void search_Name(string name)//searches for some Name
        {
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand("select * from member where Name='" + name + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //Here we are putting data readed from DB into the members of the class to call it in the search form
                M_ID = dr["ID"].ToString();
                M_Name = dr["Name"].ToString();
                num_invit = dr["Freeze"].ToString();
                num_freez = dr["invite"].ToString();
                Freeze = Convert.ToInt32(num_invit);
                Invitation = Convert.ToInt32(num_freez);
                remaind = Convert.ToInt32(dr["Remaind"].ToString());
                paid = Convert.ToInt32(dr["Last_paid"].ToString());
            }
            dr.Close();
            con.Close();
        }
        public void renew(int Id, String Term, String end_d, int freeze, int invite, int count)//updates the start date & the term
        {
            remaind = Convert.ToInt16(Add_member.remind_tmp);
            paid = Convert.ToInt16(Add_member.paid_tmp);
            cmd = new SqlCommand("Update member set Start_day='" + DateTime.Today.Day + "',Start_month='" + DateTime.Today.Month + "',Start_year='" + DateTime.Today.Year + "',Term='" + Term + "',end_date_outfreeze='" + end_d + "',Freeze='" + freeze + "',invite='" + invite + "',count='" + count + "',Remaind='"+remaind+"', Last_paid='"+paid+"'where ID='" + Id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("\tMembership updated succesfully !\nExpire Date: " + end_d + "\nInvitaions: " + invite + "\nFreeze: " + freeze + "\nPaid Amount: " + paid + "\nRemaining Amount: "+remaind, "Done :)", MessageBoxButtons.OK);

            con.Close();
        }
        public void freeze(int legnth, int Id)//updates the expir date
        {
            con.Open();
            cmd = new SqlCommand("select end_date_outfreeze,Name,Freeze from member where ID='" + Id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();


            if (RD.Read())
            {
                string name = RD["Name"].ToString();
                int freez = Convert.ToInt32(RD["Freeze"].ToString()) - legnth;
                if (freez >= 0)
                {
                    DialogResult resu = MessageBox.Show("Do you want to freeze days to Mr  '" + name + "'  ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resu == DialogResult.Yes)
                    {
                        string[] format = { "yyyy-MM-dd" };
                        DateTime Sdate;
                        DateTime.TryParseExact(RD["end_date_outfreeze"].ToString(), format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out Sdate);
                        TimeSpan Sp = TimeSpan.FromDays(legnth);
                        DateTime Edate = Sdate.Add(Sp);
                        string freez_date = Edate.ToShortDateString();
                        if (freez < 0) freez = 0;
                        cmd = new SqlCommand("Update member set end_date_outfreeze='" + freez_date + "',Freeze='" + freez + "', Freezed='" + legnth + "' WHERE ID='" + Id + "'", con);
                        RD.Close();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                else
                    MessageBox.Show("Mr '" + name + "' hasn't enough freeze days", "Sorry :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Cancel_freeze(int Frezd, int Id)//updates the expir date  
        {
            con.Open();
            cmd = new SqlCommand("select end_date_outfreeze,Freezed,Freeze from member  where ID='" + Id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();
            if (RD.Read())
            {

                int freez, legnth = Convert.ToInt32(RD["Freezed"].ToString());
                if (legnth == 0) MessageBox.Show("This member didn't make freeze to cancel", "Sorry :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (legnth == Frezd) MessageBox.Show("your freeze has been ended", "Sorry :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string[] format = { "yyyy-MM-dd" };
                    DateTime Sdate;
                    DateTime.TryParseExact(RD["end_date_outfreeze"].ToString(), format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out Sdate);
                    // DateTime Sdate =D;
                    TimeSpan Sp = TimeSpan.FromDays(Frezd);

                    freez = Convert.ToInt32(RD["Freeze"].ToString());
                    freez += legnth - Frezd;

                    TimeSpan final_span = TimeSpan.FromDays(legnth) - TimeSpan.FromDays(Frezd);
                    DateTime Edate = Sdate.Subtract(final_span);
                    string freez_date = Edate.ToShortDateString();
                    cmd = new SqlCommand("Update member set end_date_outfreeze='" + freez_date + "',Freeze='" + freez + "', Freezed='" + 0 + "' WHERE ID='" + Id + "'", con);

                    RD.Close();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }
        public void invite(int idd)//updates the number of invitations
        {
            string name;
            int count_inv;
            con.Open();
            cmd = new SqlCommand("select * from member where ID='" + idd + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();
            if (RD.Read())
            {
                name = RD["Name"].ToString();
                count_inv = Convert.ToInt32(RD["invite"].ToString());
                if (count_inv == 0)
                {
                    MessageBox.Show("There isn't any invitations for Mr : " + name, "Sorry :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    RD.Close();
                }
                else
                {
                    RD.Close();
                    DialogResult result = MessageBox.Show("The name of the member is : " + name + " ???", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        count_inv--;
                        cmd = new SqlCommand("Update member set invite='" + count_inv + "'where ID='" + idd + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Login Succesfully :)");
                    }
                    con.Close();
                }
            }
        }
        public void delete(int id)//deletes all information of the member
        {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM member where ID='" + id + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("the Memmber deleted Successfully!");
                con.Close();
        }
        public void delete_name(string name)//deletes all information of the member
        {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM member where Name='" + name + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("the Member deleted Successfully!");
                con.Close();
        }
        public bool check_admin(string name, string pass)
        {
            con.Open();
            cmd = new SqlCommand("select * from Admin_login where Admin_ID='" + name + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();


            if (RD.Read())
            {
                string pas = RD["Admin_Pass"].ToString();
                if (pass == pas)
                {
                    RD.Close();
                    con.Close();
                    return true;
                }
                else
                {
                    RD.Close();
                    con.Close();
                    return false;
                }


            }
            else
            {
                RD.Close();
                con.Close();
                return false;
            }



        }

        public bool check_manager(string name, string pass)
        {
            con.Open();
            cmd = new SqlCommand("select * from Manager where id='"+name+"'", con);
            SqlDataReader RD = cmd.ExecuteReader();


            if (RD.Read())
            {
                string pas = RD["Pass"].ToString();
                if (pass == pas)
                {
                    RD.Close();
                    con.Close();
                    return true;
                }
                else
                {
                    RD.Close();
                    con.Close();
                    return false;
                }
             }
            else
            {
                RD.Close();
                con.Close();
                return false;
            }
        }
    }
}
