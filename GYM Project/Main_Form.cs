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

        private void All_btn_Click(object sender, EventArgs e)
        {
            All_Members A = new All_Members();
            A.Show();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
