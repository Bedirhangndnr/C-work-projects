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


namespace denemesudoku
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(650, 600);
            this.MaximumSize = new Size(750, 800);
            SqlConnection conn = new SqlConnection("Data Source=EGE-PC;Initial Catalog=SUDOKU_USERS;Integrated Security=True");

            conn.Open();
            SqlCommand comm_ = new SqlCommand("select * from sudoku_users order by score desc", conn);
            SqlDataReader read_db = comm_.ExecuteReader();
            while (read_db.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read_db["user_id"].ToString(); 
                add.SubItems.Add(read_db["user_name"].ToString());
                add.SubItems.Add(read_db["score"].ToString());
                add.SubItems.Add(read_db["complated_time"].ToString());
                listView1.Items.Add(add);
            }
            conn.Close();
        }
    }
}
