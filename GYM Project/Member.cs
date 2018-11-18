﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

public struct Date
{
    public int Day, Month,Year;
};

namespace GYM_Project
{
    class Member
    {
        public int M_ID { get; set; }
        public Date Expir { get; set; }
        public int Start_day { get; set; }
        public int Start_mon { get; set; }
        public int Start_year { get; set; }
        public string Phone { get; set; }
        public int Freeze { get; set; }
        public int Invitation { get; set; }
        public string end_date { get; set; }
        public string end_date_outfreeze { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=yousef;Initial Catalog=Gym_;Integrated Security=True");
        SqlCommand cmd;
        public void Insert_new(string insert_name, string Term, int Start_day, int Start_mon, int Start_year, String phone)//Collectes & Inserts Data Into DB
        {
            Add_member add = new Add_member();

            Date date;
            //the end date
            date.Day = Add_member.df;
            date.Month = Add_member.mf;
            date.Year = Add_member.yf;
            ///////////////
         
            Freeze = Add_member.f;
            Invitation = Add_member.invite;
            end_date = Add_member.end_d;
            end_date_outfreeze = Add_member.end_date_outfr;
           DialogResult result = MessageBox.Show("Do you want to confirm your subscription for Mr:"+  insert_name + " ??" ,"" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
           if (result==DialogResult.Yes)
           {
              cmd = new SqlCommand("insert into member(Name,Term,Phone,Start_day,Start_month,Start_year,end_date,end_date_outfreeze,End_day,End_month,End_year,Freeze,invite,count)values (N'" + insert_name + "',N'" + Term + "',N'" + phone + "','" + Start_day + "','" + Start_mon + "','" + Start_year + "','" + end_date + "','"+end_date_outfreeze+"','" + date.Day + "','" + date.Month + "','" + date.Year + "','" + Freeze + "','" + Invitation + "','" + Add_member.count + "')", con);
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
               MessageBox.Show("Data is recorded for Mr : " + insert_name +"\nEnd date is : " + end_date_outfreeze + "\nInvitaions : " + Invitation + "\nFreeze : " + Freeze, "Done :)", MessageBoxButtons.OK);
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
                int year, month, day = Convert.ToInt32(RD["End_day"].ToString());
                month = Convert.ToInt32(RD["End_month"].ToString());
                year = Convert.ToInt32(RD["End_year"].ToString());
                
                int c = Convert.ToInt32(RD["count"]);
                string name = RD["Name"].ToString();
                string endd = RD["end_date_outfreeze"].ToString();
                DialogResult resu = MessageBox.Show("Name : " + name +'\n'+"you still have "+RD["Freeze"]+" freeze days and "+RD["invite"]+" invitations "+'\n' +"till : "+ endd , "Do you want to login with this details ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                RD.Close();
                if (resu == DialogResult.Yes)
                {
                    DateTime End = new DateTime(year, month, day);
                    if (DateTime.Today <= End)
                    {
                        MessageBox.Show("Loged In Successfully !", "Succeeded !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        c--;
                        cmd = new SqlCommand("Update member set count='" + c + "'where ID='" + Id + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
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
                }
               
            }
            else if (!RD.Read())
                MessageBox.Show("Member Not Exist !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            con.Close();
        }
        public void search_ID(int Id)//searches for some ID
        {

        }
        public void search_Name(String name)//searches for some Name
        {

        }
        public void renew(int Id,String Term,int df,int mf,int yf,string end_f,String end_d,int freeze,int invite,int count )//updates the start date & the term
        {
            cmd = new SqlCommand("Update member set Start_day='"+DateTime.Today.Day+"',Start_month='"+DateTime.Today.Month+"',Start_year='"+DateTime.Today.Year+"',Term='"+Term+"',End_day='"+df+ "',End_month='" + mf + "',End_year='" + yf + "',end_date='"+end_f+"',end_date_outfreeze='"+end_d+"',Freeze='"+freeze+"',invite='"+invite+"',count='"+count+"'where ID='"+Id+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("\tMembership updated succesfully !\nExpire Date : " + end_d + "\nInvitaions : " + Invitation + "\nFreeze : " + Freeze, "Done :)", MessageBoxButtons.OK);

            con.Close();
        }
        public void freeze(int legnth,int Id)//updates the expir date
        {
            
            con.Open();
            cmd = new SqlCommand("select End_day,End_month,End_year from member where ID='" + Id + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();

            if (RD.Read())
            {
                int year, month, day = Convert.ToInt32(RD["End_day"].ToString());
                month = Convert.ToInt32(RD["End_month"].ToString());
                year = Convert.ToInt32(RD["End_year"].ToString());

                DateTime Sdate = new DateTime(year, month, day);
                TimeSpan span = TimeSpan.FromDays(legnth);
                DateTime Edate = Sdate.Add(span);
                string freez_date = Edate.ToShortDateString();
                cmd = new SqlCommand("Update member set end_date_outfreeze='" + freez_date + "'where ID='" + Id + "'", con);
                 RD.Close();
                cmd.ExecuteNonQuery();
               


            }
            con.Close();
        }
        public void Cancel_freeze(int legnth, Date date)//updates the expir date  
        {

        }
        public void invite(int idd)//updates the number of invitations  **(this function may be removed)**
        {
            string name;
            int count_inv;
            con.Open();
            cmd = new SqlCommand("select * from member where ID='" + idd + "'", con);
            SqlDataReader RD = cmd.ExecuteReader();
            if(RD.Read())
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
                    DialogResult result=MessageBox.Show("The name of the member is : " + name+" ???"," ",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if(result==DialogResult.Yes)
                    {
                        count_inv--;
                        cmd = new SqlCommand("Update member set invite='"+count_inv+"'where ID='"+idd+"'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Login Succesfully :)");
                    }
                    con.Close();
                }
            }
        }
        public void  delete(int id)//deletes all information of the member
        {

        }


    }
}
