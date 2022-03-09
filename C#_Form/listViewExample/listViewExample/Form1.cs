namespace listViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC", 120);
            listView1.Columns.Add("AD SOYAD", 180);
            listView1.Columns.Add("YAS", 50);
            listView1.Columns.Add("MEZUNIYET", 120);
            listView1.Columns.Add("CINSIYET", 80);
            listView1.Columns.Add("DOGUM YERI", 100);
            listView1.Columns.Add("TELEFON NO", 120);
            string[] mezuniyet = { "ilk ogretim", "orta ogretim", "lisans", "yuksek lisans", "doktora" };
            comboBox1.Items.AddRange(mezuniyet);
        }
        private void kayitSayisiYaz()
        {
            int kayitSayisi= listView1.Items.Count;
            label7.Text = "kayit sayisi: " + Convert.ToString(kayitSayisi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TC = "", adsoyad = "",yas="", mezuniyet = "", cinsiyet = "", dogumyeri="", telno="";
            TC = textBox1.Text;
            adsoyad = textBox2.Text;
            yas = textBox3.Text;
            dogumyeri = textBox5.Text;
            telno = textBox4.Text;
            mezuniyet = comboBox1.Text;
            if (radioButton1.Checked)
                cinsiyet = radioButton1.Text;
            else if(radioButton2.Checked)
                cinsiyet = radioButton2.Text;
            string[] bilgiler = { TC, adsoyad, yas, mezuniyet, cinsiyet, dogumyeri, telno };

            bool isExsist = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //subıtems[0]= tc no
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    isExsist = true;
                    MessageBox.Show("this member is already exist!");
                }
            }
            if (isExsist == false)
            {

                ListViewItem item = new ListViewItem(bilgiler);
                if (TC != "" && adsoyad != "" && yas != "" && mezuniyet != "" && cinsiyet != "" && dogumyeri != "" && telno != "")
                {
                    listView1.Items.Add(item);
                }
                else
                    MessageBox.Show("kayit bilgilerinde eksiklik var");
            }
            kayitSayisiYaz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int checkedCount= listView1.CheckedItems.Count;
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                item.Remove();
            }
            MessageBox.Show(checkedCount.ToString()+" kayit silindi");
            kayitSayisiYaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int SelectedCount = listView1.SelectedItems.Count;
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                item.Remove();
            }
            MessageBox.Show("1 kayit silindi");
            kayitSayisiYaz();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            kayitSayisiYaz();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
            groupBox1.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    isExist = true;
                    textBox2.Text=listView1.Items[i].SubItems[1].Text;
                    textBox3.Text=listView1.Items[i].SubItems[2].Text;
                    comboBox1.Text=listView1.Items[i].SubItems[3].Text;
                    if (listView1.Items[i].SubItems[4].Text=="erkek")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[4].Text == "kadın")
                    {
                        radioButton2.Checked = true;
                    }
                    textBox4.Text=listView1.Items[i].SubItems[5].Text;
                    textBox5.Text= listView1.Items[i].SubItems[6].Text;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    comboBox1.Enabled = false;
                    groupBox1.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;

                }
                if (isExist == false)
                {
                    MessageBox.Show(textBox1.Text + " tc kimlik nolu kayit bulunamadi")
                }


            }
        }
    }
}