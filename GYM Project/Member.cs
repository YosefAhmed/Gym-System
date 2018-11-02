using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Date
{
    int Day, Month,Year;
};
struct Full_Name
{
    string F_Name, M_Name, L_Name;
}
namespace GYM_Project
{
    class Member
    {
        public Full_Name Name { get; set; }
        public int M_ID { get; set; }
        public int   Term { get; set; }
        public Date Start_date { get; set; }
        public Date Expir { get; set; }
        public int Phone { get; set; }
        public int Freeze { get; set; }
        public int Invitation { get; set; }


        public void Insert_new(Full_Name name,int Id,int term,Date date,int phone)//Collectes & Inserts Data Into DB
        {
        }

        public void Check(int Id)//checkes if ID is existed & if membership is available
        {

        }
        public void search_ID(int Id)//searches for some ID
        {

        }
        public void search_Name(Full_Name name)//searches for some Name
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
