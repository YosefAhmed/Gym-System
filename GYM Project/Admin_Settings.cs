using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GYM_Project
{
    public partial class Admin_Settings : UserControl
    {
        
        public Admin_Settings()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Year_txt.Text == "" || Six_M_txt.Text == "" || three_M_txt.Text == "" || one_M_txt.Text == "")
            {
                MessageBox.Show("Please enter all data !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
          
            Main F = new Main();
            F.Show();
            ParentForm.Hide();
            }
        }

        private void Admin_Settings_Load(object sender, EventArgs e)
        {

        }


    }
}
