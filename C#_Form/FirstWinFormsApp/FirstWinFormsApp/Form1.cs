namespace FirstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("welcome");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1= Convert.ToDouble(textBox1.Text);
            sayi2= Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label4.Text = Convert.ToString(sonuc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label4.Text = Convert.ToString(sonuc);

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void button5_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label4.Text = Convert.ToString(sonuc);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}