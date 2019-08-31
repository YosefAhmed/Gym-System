using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Project
{
    public partial class Record : UserControl
    {
        public Record()
        {
            InitializeComponent();
        }
        public void put(string id,string name, string term,string phone, string sdate, string edate, string fr, string inv,string cou)
        {
            idlbl.Text = id;
            namelbl.Text = name;
            tlbl.Text = term;
            plbl.Text = phone;
            slbl.Text = sdate;
            elbl.Text = edate;
            flbl.Text = fr;
            ilbl.Text = inv;
            clbl.Text = cou;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
