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

namespace DictionaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=EGE-PC;Initial Catalog=vt_sozluk;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("aaa");

                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into ingturkce (a, b) values ('"+textBox1.Text + "','"+
                    textBox2.Text +"')", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("query");
                dr.Close();
                MessageBox.Show("sözcük db'ye eklendi.");

            }
            catch (Exception)
            {
                Console.WriteLine("quasery");
                throw;
            }
        }
    }
}