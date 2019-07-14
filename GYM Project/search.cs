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
    public partial class search : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=yousef\YOUSEF;Initial Catalog=test 1 gym;Integrated Security=True");
        SqlDataAdapter Da;
        DataSet Ds = new DataSet();
        SqlCommand cmd;
        SqlDataReader RD;
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
        }
    }
}
