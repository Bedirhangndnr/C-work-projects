namespace JOB_APPLICATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] languages = {"turkish", "english", "french", "german"}; 
            checkedListBox1.Items.AddRange(languages);
            checkedListBox1.MultiColumn= true;
            checkedListBox1.CheckOnClick=true;
            button1.Enabled=false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem); 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //yeni dil ekle 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                if (checkedListBox1.Items.Contains(textBox2.Text) == false)
                    checkedListBox1.Items.Add(textBox2.Text);
                else
                    MessageBox.Show("belirtilen dil zaten eklidir!");
                textBox2.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
                button1.Enabled = true;
            else
                button1.Enabled &= false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count>0)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            string diller = "", mezuniyet="";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                diller += ", " + checkedListBox1.CheckedItems[i];
            }
            diller= diller.Substring(2);
            label7.Text = diller;

            if (radioButton1.Checked)
                mezuniyet = radioButton1.Text;
            else if (radioButton2.Checked)
                mezuniyet = radioButton2.Text;
            else if (radioButton2.Checked)
                mezuniyet = radioButton3.Text;
            else if (radioButton2.Checked)
                mezuniyet = radioButton4.Text;
            label8.Text=mezuniyet;



        }
    }
}