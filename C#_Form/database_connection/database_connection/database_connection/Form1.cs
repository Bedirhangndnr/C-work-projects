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
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM bilgiler", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = dr["adsoyad"].ToString();//ilk alan için text uygun, diğer alnlar için subitems uygundur.
                add.SubItems.Add(dr["sehir"].ToString());
                add.SubItems.Add(dr["okul"].ToString());
                add.SubItems.Add(dr["no"].ToString());

                listView1.Items.Add(add);
            }
            conn.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_datas();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand conn_ = new SqlCommand("Insert INTO bilgiler (adsoyad, sehir, okul, no) Values ('" + textBox1.Text.ToString() + "','" +
                textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "')", conn);
            conn_.ExecuteNonQuery();
            conn.Close();
            show_datas();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        int id = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from bilgiler where no=(" + id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            show_datas();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void No_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
