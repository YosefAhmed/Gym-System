﻿using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=MOSTAFA\SQLEXPRESS;Initial Catalog=Gym_mostafa;Integrated Security=True");
        SqlCommand cmd;
        public Admin_Settings()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (Year_txt.Text == "" || Six_M_txt.Text == "" || three_M_txt.Text == "" || one_M_txt.Text == "")
            {
                MessageBox.Show("Please enter all data !! ");
            }
            else
            {
            cmd = new SqlCommand("insert into Price (Price_1Y, Price_6M, Price_3M, Price_1M)values('" + Year_txt.Text + "','" + Six_M_txt.Text + "','" + three_M_txt.Text + "','" + one_M_txt.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
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
