﻿using System;
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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Admin_Login_btn_Click(object sender, EventArgs e)
        {
            Main F = new Main();
            Member M = new Member();
            if (M.check_admin(username_txt.Text,Password_txt.Text))
            {
                F.Show();
                this.Hide();         
                
            }
            else
                Wrong_lbl.Text = "* Wrong Username Or Password, Please Try Again !! *";
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please Be Sure To Set The Time In Your Computer To Avoid Data Recording Errors !!\n \nمن فضلك تأكد من ضبط الوقت والتاريخ  في جهازك تجنباً لأخطاء حفظ البيانات !! ","Attention !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
