using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Arithmetic_Operations arithmetic_operations = new Arithmetic_Operations();
        string keep_sign = "";
        double main_value = 0;
        double value_1 = 0;
        double value_2 = 0;
        double result;
        const double PI = Math.PI;
        const double eval = 2.7182818284590452;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Normall Calculator");
            comboBox1.Items.Add("Scientific Calculator");
            comboBox1.SelectedIndex = 1;
            var size = new Size(400, 450);
            this.MinimumSize= size;
        }
        public void Edit_Textbox_Fieds(Button button)
        {
            keep_sign = button.Text;
            if (textBox1.Text != "")
            {
                value_1 = Convert.ToDouble(textBox1.Text);
                main_value = Convert.ToDouble(textBox1.Text);
            }
            textBox2.Text = Convert.ToString(main_value) + keep_sign;

            textBox1.Text = "";

            MessageBox.Show(keep_sign);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button7);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button17.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button11.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + button13.Text;
            //btnSayiBir
            //txtbx
            //lbl
            //drpbx
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button14.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button15.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button18.Text;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button19.Text;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button22.Text;

        }

        public void CE()
        {
            keep_sign = "";
            main_value = 0;
            value_1 = 0;
            value_2 = 0;
            result = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "Deleted!";
            label2.BackColor = Color.Green;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CE();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CE();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            if (s.Length > 1)
            {
                textBox1.Text = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button8);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button12);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button16);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button20);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button21);


        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;
            if (textBox1.Text != "")
            {
                value_1 = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                value_1 = 0;
            }
            if (keep_sign == "%")
            {
                result = arithmetic_operations.Mod(main_value, value_1);
                textBox1.Text = "";
                textBox1.Text = Convert.ToString(result);
                main_value = result;
            }

            else if (keep_sign == "1/x")
            {
                result = arithmetic_operations.One_Div_value(main_value);
                textBox2.Text = Convert.ToString(arithmetic_operations.One_Div_value(main_value));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }

            else if (keep_sign == "x^2")
            {
                result = arithmetic_operations.Square(main_value);
                textBox2.Text = Convert.ToString(arithmetic_operations.Square(main_value));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "√¯x")
            {
                result = arithmetic_operations.Square_Root(main_value);
                textBox2.Text = Convert.ToString(arithmetic_operations.Square_Root(main_value));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "/")
            {
                result = arithmetic_operations.Divide(main_value, value_1);
                textBox2.Text = Convert.ToString(arithmetic_operations.Divide(main_value, value_1));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "x")
            {
                result = arithmetic_operations.Multiple(main_value, value_1);
                textBox2.Text = Convert.ToString(arithmetic_operations.Multiple(main_value, value_1));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "-")
            {
                result = arithmetic_operations.Minus(main_value, value_1);
                textBox2.Text = Convert.ToString(arithmetic_operations.Minus(main_value, value_1));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "+")
            {
                result = arithmetic_operations.Plus(main_value, value_1);
                textBox2.Text = Convert.ToString(arithmetic_operations.Plus(main_value, value_1));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "+/-")
            {
                result = arithmetic_operations.Reverse_Sign(main_value);
                textBox2.Text = Convert.ToString(arithmetic_operations.Reverse_Sign(main_value));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "xupy")
            {
                result = arithmetic_operations.xupy(main_value, value_1);
                textBox2.Text = Convert.ToString(arithmetic_operations.xupy(main_value, value_1));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "10^x")
            {
                result = arithmetic_operations._10upx(main_value);
                textBox2.Text = Convert.ToString(arithmetic_operations._10upx(main_value));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
            else if (keep_sign == "n!")
            {
                result = arithmetic_operations.fact(main_value);
                textBox2.Text = Convert.ToString(arithmetic_operations.fact(main_value));
                textBox1.Text = "";
                textBox2.Text = Convert.ToString(result);
                main_value = result;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Scientific Calculator")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            result = arithmetic_operations._2nd(Convert.ToInt32(textBox1.Text));
            textBox2.Text = Convert.ToString(arithmetic_operations._2nd(main_value));
            textBox1.Text = "";
            textBox2.Text = Convert.ToString(result);
            main_value = result;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button28);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button27);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(eval);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(PI);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Edit_Textbox_Fieds(button29);


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Normall Calculator")
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
    }
}
