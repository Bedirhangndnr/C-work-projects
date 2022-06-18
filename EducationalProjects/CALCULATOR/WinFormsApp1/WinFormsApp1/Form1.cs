using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Arithmetic_Operations arithmetic_operations = new Arithmetic_Operations();
        string keep_sign = "";
        string keep_current_txtbox2 = "";
        int keep_last_number = 0;
        double main_value = 0;
        double value_1 = 0;
        double value_2 = 0;
        double result;
        string transactions = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Normall Calculator");
            comboBox1.Items.Add("Scientific Calculator");
            comboBox1.SelectedIndex = 0;
            var size = new Size(400, 450);
            this.MinimumSize = size;
        }
        private void if_click_anumber(Button number_button)
        {
            textBox1.Text = textBox1.Text + number_button.Text;
            keep_last_number = Convert.ToInt32(number_button.Text);
        }
        private void do_if_multiple_or_devide(Button number_button)
        {
            if(keep_sign=="/" && keep_sign == "x")
            {
                main_value = main_value - keep_last_number + keep_last_number * value_1;
            }
        }
        public void Edit_Textbox_Fieds(Button button)
        {
            keep_current_txtbox2 = textBox2.Text;
            keep_sign = button.Text;
            if (textBox1.Text != "")
            {
                value_1 = Convert.ToDouble(textBox1.Text);
                main_value = Convert.ToDouble(textBox1.Text);
            }
            textBox2.Text += textBox1.Text+keep_sign;
            textBox1.Text = "";
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
            if_click_anumber(button17);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if_click_anumber(button9);

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if_click_anumber(button10);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if_click_anumber(button11);

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if_click_anumber(button13);
            //btnSayiBir
            //txtbx
            //lbl
            //drpbx
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if_click_anumber(button14);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if_click_anumber(button15);
            transaction_priorities(textBox2.Text);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if_click_anumber(button18);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if_click_anumber(button19);

        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            if_click_anumber(button22);

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
            string[] substr = textBox2.Text.Split('+', '-', '*', '/');
            string[] newArray = (new ArraySegment<string>(substr, 0,
                substr.Length - 2)).ToArray();
            MessageBox.Show(Convert.ToString(substr.Length));
            MessageBox.Show(Convert.ToString(newArray.Length));

            foreach (var item in newArray)
            {
                MessageBox.Show(item);
            }
            textBox2.Text = keep_current_txtbox2;
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
        public void transaction_priorities(string txtBox2)
        {
            MessageBox.Show(Convert.ToString(txtBox2.IndexOf("*")));
        }
        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;
            if (textBox1.Text!= "")
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
                result = arithmetic_operations.Divide(main_value,value_1);
                textBox2.Text = Convert.ToString(arithmetic_operations.Divide(main_value,value_1));
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
                result = arithmetic_operations.Minus(main_value,value_1);
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="Scientific Calculator")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        }
    }
