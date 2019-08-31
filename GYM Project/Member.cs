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
using System.Xml.Serialization;
using System.IO;
public struct Date
{
    public int Day, Month,Year;
};

namespace GYM_Project
{
  public class Member
    {
        public static List<customer> membersdata = new List<customer>();

        public void Insert_new(string insert_name, string Term, string S_date,string e_date, String phone)//Collectes & Inserts Data Into DB
        {
            GetMembers();
            customer m = new customer();
            m.id = (membersdata.Count+100).ToString();
            m.name = insert_name;
            m.term = Term;
            m.start_date = S_date;
            m.end_date = e_date;
            m.phone = phone;
            if (!File.Exists("members.xml"))
            {
                membersdata.Add(m);
                FileStream f = new FileStream("members.xml", FileMode.Create);
                XmlSerializer ser = new XmlSerializer(membersdata.GetType());
                ser.Serialize(f, membersdata);
                f.Close();
            }
            else
            {
                GetMembers();
                membersdata.Add(m);
                FileStream f = new FileStream("members.xml", FileMode.Create);
                XmlSerializer ser = new XmlSerializer(membersdata.GetType());
                ser.Serialize(f, membersdata);
                f.Close();
            }
            DialogResult result = MessageBox.Show("Do you want to confirm your subscription for Mr:" + insert_name + " ??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                MessageBox.Show("Data is recorded for Mr : " + insert_name  , "Done :)", MessageBoxButtons.OK);
            }
        }
        public static void GetMembers()
        {
            membersdata.Clear();
            if(File.Exists("members.xml"))
            {
                XmlSerializer ser = new XmlSerializer(membersdata.GetType());
                FileStream fs = new FileStream("members.xml", FileMode.Open);
                membersdata = (List<customer>)ser.Deserialize(fs);
                fs.Close();
            }
        }
        //public bool Check_exist(int Id)
        //{
            

        //}
        //public bool Check_exist_name(string name)
        //{
            

        //}
        public static int re_id;
        public void Check(int Id)//checkes if ID is existed & if membership is available
        {

        }
        public string m_id;
        public string m_name;
        public string num_invit;
        public string num_freez;

        public void search_ID(int Id)//searches for some ID
        {
           
        }
        public void search_Name(string name)//searches for some Name
        {
           
        }
        public void renew(int Id, String Term, String end_d, int freeze, int invite, int count)//updates the start date & the term
        {
           
        }
        public void freeze(int legnth, int Id)//updates the expir date
        {
           

        }
        public void Cancel_freeze(int Frezd, int Id)//updates the expir date  
        {
           
        }
        public void invite(int idd)//updates the number of invitations  **(this function may be removed)**
        {
           
        }
        public void delete(int id)//deletes all information of the member
        {
            DialogResult del = MessageBox.Show("Are you Sure you want to delete the:'" + id + "'", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (del == DialogResult.Yes)
            {
              
            }


        }
        public void delete_name(string name)//deletes all information of the member
        {
            DialogResult del = MessageBox.Show("Are you Sure you want to delete the:'" + name + "'", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (del == DialogResult.Yes)
            {
               
            }


        }
        //public bool check_admin(string name, string pass)
        //{
          

        //}

        //public bool check_manager(string name, string pass)
        //{

        // }
    }
}
