using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OutlookDemo.UserControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            dB.openConnection();
            MySqlCommand com = new MySqlCommand("SELECT * FROM `users`", dB.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(com);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            if (ds.Rows.Count > 0) 
            { 
                MessageBox.Show("Eaffaf");
                guna2HtmlLabel1.Text = ds.Rows[0][0].ToString();
            }
              

        }
    }
}
