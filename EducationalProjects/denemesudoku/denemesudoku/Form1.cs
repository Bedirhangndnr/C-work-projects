using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;


namespace denemesudoku
{
    public partial class Form1 : Form
    {
        Button[,] buttons = new Button[10, 10];
        static string[,] buttons_values = new string[10, 10];

        public static bool SolveSudoku(Button[,] puzzle, int row, int col)
        {
            if (row < 9 && col < 9)
            {
                if (puzzle[row, col].Text != "-1")
                {
                    if ((col + 1) < 9) return SolveSudoku(puzzle, row, col + 1);
                    else if ((row + 1) < 9) return SolveSudoku(puzzle, row + 1, 0);
                    else return true;
                }
                else
                {
                    for (int i = 0; i < 9; ++i)
                    {
                        if (IsAvailable(puzzle, row, col, i + 1))
                        {
                            puzzle[row, col].Text = Convert.ToString(i + 1);
                            buttons_values[row, col] = puzzle[row, col].Text;

                            if ((col + 1) < 9)
                            {
                                if (SolveSudoku(puzzle, row, col + 1)) return true;
                                else puzzle[row, col].Text = "-1";
                            }
                            else if ((row + 1) < 9)
                            {
                                if (SolveSudoku(puzzle, row + 1, 0)) return true;
                                else puzzle[row, col].Text = "-1";
                            }
                            else return true;
                        }
                    }
                }

                return false;
            }
            else return true;
        }

        private static bool IsAvailable(Button[,] puzzle, int row, int col, int num)
        {
            int rowStart = (row / 3) * 3;
            int colStart = (col / 3) * 3;

            for (int i = 0; i < 9; ++i)
            {
                if (puzzle[row, i].Text == num.ToString()) return false;
                if (puzzle[i, col].Text == num.ToString()) return false;
                if (puzzle[rowStart + (i % 3), colStart + (i / 3)].Text == num.ToString()) return false;
            }

            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=EGE-PC;Initial Catalog=SUDOKU_USERS;Integrated Security=True");

        private void show_datas()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM sudoku_users", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem add = new ListViewItem();
                //MessageBox.Show(dr["user_name"].ToString());//ilk alan için text uygun, diğer alnlar için subitems uygundur.
            }
            conn.Close();
        }
        public void create_sudoku_buttons()
        {
            int[] numbers1 = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var counter = 0;

            // repeat until all 8 valid random numbers are generated 
            do
            {
                // generate a random number between 1 and 49 
                Random random_ = new Random();
                var randomNumber = random_.Next(1, 10);

                // if the numbers array doesn't contain the random number 
                // add the random number to the array and increment the counter 
                if (Array.IndexOf(numbers1, randomNumber) == -1)
                {
                    numbers1[counter] = randomNumber;
                    counter++;
                }
            } while (counter <= 8);

            // display the first 7 numbers separated by comma 
            for (var i = 0; i < numbers1.Length - 1; i++)
            {
                //MessageBox.Show(numbers1[i] + ",");
            }

            // display the last number which doesn't have a comma 
            //MessageBox.Show(Convert.ToString(numbers1[numbers1.Length - 1]));

            this.MinimumSize = new Size(830, 620);
            this.MaximumSize = new Size(880, 620);
            int top = 20;
            int left = 80;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {

                    buttons[i, j] = new Button();
                    buttons[i, j].Tag = i.ToString() + "," + j.ToString();
                    buttons[i, j].Click += buttonOk_Click;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    if (i == 0)
                    {
                        buttons[i, j].Text = Convert.ToString(numbers1[j]);
                        buttons_values[i, j] = buttons[i, j].Text;
                    }
                    else
                    {
                        buttons[i, j].Text = "-1";
                    }

                    left += 50;
                    buttons[i, j].Top = top;
                    if ((i % 2 == 1 && j % 2 == 0) || (i % 2 == 0 && j % 2 == 1)) // or we can do that: if((i+j)%2==1){...}
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                    //buttons[1, 1].Click += new EventHandler(buttonOk_Click);



                }
                top += 50;
                left = 80;
                //try_to_fill_box(1, 2, buttons, 1);
            }
        }
        private void save_to_database()
        {

        }
        int button_row_loc;
        int button_col_loc;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            show_datas();
            create_sudoku_buttons();

        }
        int numbers_to_fill;
        String level = "";
        bool checked_a_level = false;
        string entered_value;
        int number_of_change = 3;
        void buttonOk_Click(object sender, EventArgs e)
        {
            Button someButton = sender as Button;

            string[] indexes = someButton.Tag.ToString().Split(',');
            int row = Convert.ToInt32(indexes[0]);
            int col = Convert.ToInt32(indexes[1]);
            if (number_of_change > 0)
            {
                if (someButton != null && number_bx.Text != "")
                {
                    string predict = number_bx.Text;
                    someButton.ForeColor = Color.GreenYellow;
                }
                else
                {
                    MessageBox.Show("Please Enter a value.");
                }
                if (buttons_values[row, col] == number_bx.Text)
                {
                    success_or_not_lbl.ForeColor = Color.DarkGreen;
                    someButton.ForeColor = Color.DarkGreen;
                    someButton.Text = buttons_values[row, col].ToString();
                    success_or_not_lbl.Text = someButton.Text;
                }
                else
                {
                    success_or_not_lbl.ForeColor = Color.Red;
                    success_or_not_lbl.Text = someButton.Text;
                    number_of_change -= 1;
                }
            }
            if (number_of_change == 0)
            {
                MessageBox.Show("Game over.");
            }



        }
        private void easy_btn_CheckedChanged(object sender, EventArgs e)
        {
            level = "easy";
            number_of_change = 3;
            numbers_to_fill = 50;
            checked_a_level = true;
        }

        private void medium_btn_CheckedChanged(object sender, EventArgs e)
        {
            level = "medium";
            number_of_change = 3;
            numbers_to_fill = 35;
            checked_a_level = true;
        }

        private void hard_btn_CheckedChanged(object sender, EventArgs e)
        {
            level = "hard";
            number_of_change = 3;
            numbers_to_fill = 20;
            checked_a_level = true;
        }
        bool play_buton_clicked = false;
        private void play_btn_Click(object sender, EventArgs e)
        {
            min_ = 0;
            sec_ = 0;
            timer1.Start();
            timer2.Start();
            play_buton_clicked = true;
            score_lbl_.Text = "0";
            time_lbl_.Text = "0";
            if (checked_a_level == false)
            {
                warning_lbl.ForeColor = Color.Red;
                warning_lbl.Text = "Please select a level. ";
            }
            else
            {

                for (int i = 0; i < buttons.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < buttons.GetUpperBound(1); j++)
                    {
                        buttons[i, j].ForeColor = Color.Black;
                        if (i >= 1)
                        {
                            buttons[i, j].Text = "-1";
                        }
                    }
                }
                SolveSudoku(buttons, 0, 0);
                warning_lbl.Hide();


                Button[,] buttons_ = buttons;
                List<int> numbers = new List<int> { };
                for (int k = 0; k < 81; k++)
                    numbers.Add(k);
                int[] percentage = Enumerable.Range(0, 100).ToArray();


                Random random = new Random();
                List<int> MyRandomArray = numbers.OrderBy(x => random.Next()).ToList();

                for (int idx_random_number = 0; idx_random_number < numbers_to_fill; idx_random_number++)
                {
                    int i = MyRandomArray[idx_random_number] / 9;
                    int j = MyRandomArray[idx_random_number] % 9;
                    buttons_[i, j].ForeColor = Color.Red;

                }
                for (int i = 0; i < buttons_.GetUpperBound(0); i++)
                {
                    for (int j = 0; j < buttons_.GetUpperBound(1); j++)
                    {
                        if (!(buttons_[i, j].ForeColor == Color.Red))
                        {
                            buttons_[i, j].Text = " ";
                        }
                    }
                }




            }

        }
        private void easy_btn__CheckedChanged(object sender, EventArgs e)
        {
            level = "easy";
            number_of_change = 3;
            numbers_to_fill = 50;
            checked_a_level = true;
        }

        private void medium_btn__CheckedChanged(object sender, EventArgs e)
        {
            level = "medium";
            number_of_change = 3;
            numbers_to_fill = 35;
            checked_a_level = true;
        }

        private void hard_btn__CheckedChanged(object sender, EventArgs e)
        {
            level = "hard";
            number_of_change = 3;
            numbers_to_fill = 20;
            checked_a_level = true;
        }
        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (username_txtbx_.Text != "" && play_buton_clicked)
            {
                //conn.Open();
                //SqlCommand comm_ = new SqlCommand("select user_id from sudoku_users where user_name= '" + username_txtbx_.Text.ToString() + "' group by user_id", conn);
                //SqlDataReader read_db = comm_.ExecuteReader();
                //if (read_db.Read())
                //{
                //    id_lbl_.Text = read_db["user_id"].ToString();
                //}
                //conn.Close();

                //conn.Open();
                //SqlCommand comm_add_id = new SqlCommand("select * from sudoku_users where user_id= (select max(user_id) from sudoku_users)", conn);
                //SqlDataReader read_id = comm_add_id.ExecuteReader();
                //if (read_id.Read())
                //{
                //    id_lbl_.Text = read_id["user_id"].ToString();
                //}
                //int id = Convert.ToInt32(read_id["user_id"].ToString()) + 1;
                //conn.Close();

                //conn.Open();
                //SqlCommand comm = new SqlCommand("insert into sudoku_users (user_id, user_name, score, complated_time) values ('" + id + "','" + username_txtbx_.Text.ToString() +
                //    "','" + score_lbl_.Text.ToString() + "','" + time_lbl_.Text.ToString() + "')", conn);
                //comm.ExecuteNonQuery();
                //conn.Close();

                conn.Open();
                string query = "insert into users_scores (name,score,complate_time)" +
                    " values ('" + username_txtbx_.Text.ToString() + "','" 
                    + Convert.ToDecimal(score_lbl_.Text) + "','" + Convert.ToDecimal(time_lbl_.Text) + "')";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("please check if u click enter button or not. Or make sure entered an username");
            }

        }
        // multithreading gerekirdi yapmadım.
        int min_;
        int sec_;
        private void timer1_Tick(object sender, EventArgs e)
        {
            min_++;
            //time_lbl_.Text = Convert.ToString(min_);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec_++;
            time_lbl_.Text = Convert.ToString(sec_);
        }

        private void arrengement_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

