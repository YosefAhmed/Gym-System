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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O1FM280\SQLEXPRESS;Initial Catalog=Gym;Integrated Security=True");
        SqlCommand cmd;

        public void Insert_new(string insert_name, string Term, int Start_day, int Start_mon, int Start_year, String phone)//Collectes & Inserts Data Into DB
        {
            Add_member add = new Add_member();

            Date date;
            //the end date
            date.Day = Add_member.d;
            date.Month = Add_member.editedmon;
            date.Year = Add_member.y;
            ///////////////
         
            Freeze = Add_member.f;
            Invitation = Add_member.invite;
            end_date = Add_member.end_d;
           DialogResult result = MessageBox.Show("Do you want to confirm your subscription for Mr:"+  insert_name + " ??" ,"" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
           if (result==DialogResult.Yes)
           {
              cmd = new SqlCommand("insert into member(Name,Term,Phone,Start_day,Start_month,Start_year,end_date,End_day,End_month,End_year,Freeze,invite,count)values (N'" + insert_name + "',N'" + Term + "',N'" + phone + "','" + Start_day + "','" + Start_mon + "','" + Start_year + "','" + end_date + "','" + date.Day + "','" + date.Month + "','" + date.Year + "','" + Freeze + "','" + Invitation + "','" + Add_member.count + "')", con);
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
               MessageBox.Show("Data is recorded for Mr : " + insert_name + "  :)" + '\n' + "End date is : " + end_date + '\n' + "Invitaions : " + Invitation + "            Freeze : " + Freeze, "Done :)", MessageBoxButtons.OK);
           }
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


                DateTime End = new DateTime(year, day, month);
                if (DateTime.Today <= End)
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
        public void search_Name(String name)//searches for some Name
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
