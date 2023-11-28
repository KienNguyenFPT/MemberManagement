using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string query = "select * from Infor";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder builder = new StringBuilder();
                    while (reader.Read())
                    {

                        builder.Append(reader.GetString(1)
                            + " " + reader.GetString(3) + " " + reader.GetString(4)
                            + " " + reader.GetString(5));
                        MessageBox.Show(builder.ToString());
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
