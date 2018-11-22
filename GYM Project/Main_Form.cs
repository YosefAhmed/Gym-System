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
    public partial class Main_Form : UserControl
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void member_btn_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            Search_Form A = new Search_Form();
            A.Show();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            Add_member add = new Add_member();
            add.Show();
        }
    }
}
