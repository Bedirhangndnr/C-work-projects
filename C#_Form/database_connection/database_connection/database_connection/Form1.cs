using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn= new SqlConnection("Data Source=EGE-PC;Initial Catalog=Ornek;Integrated Security=True");
         
        private void show_datas()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM bilgiler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["adsoyad"].ToString();
                add.SubItems.Add(dr["sehir"].ToString());
                add.SubItems.Add(dr["okul"].ToString()); 
                listView1.Items.Add(add);
            }
            conn.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_datas();
        }
    }
}
