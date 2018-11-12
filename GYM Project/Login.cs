using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.Check(Convert.ToInt32(ID_txt.Text));
        }
    }
}
