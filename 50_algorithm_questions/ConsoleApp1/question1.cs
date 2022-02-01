using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class questions
    {
        public questions() { }
        public void answer1()
        {
            Console.WriteLine("Enter 2 numbers to add");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            int result = s1 + s2;
            Console.WriteLine("result: {0}", result);
        }


        public void answer2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("nahrideb");
            }
        }




        public void answer3()
        {
            Console.WriteLine("Your name will be written as the number you entered. Enter a number.");
            int input_number=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input_number; i++)
            {
                Console.WriteLine("nahrideb");
            }
        }
        public void answer4()
        {
            Console.WriteLine("Enter a word and number sequentially. Word will be written as the number you entered.");
            string word = Console.ReadLine();
            int input_number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < input_number; i++)
            {
                Console.WriteLine(word);
            }
        }
        public void answer5()
        {
            Console.WriteLine("Enter two number, will be writen from first number to second number.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; i < n2; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void answer6()
        {
            Console.WriteLine("Enter two number, will be writen from first number to second number but only even numbers.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; i < n2; i++)
            {
                if(i%2==0) Console.WriteLine(i);
            }
        }

        public void answer7()
        {
            Console.WriteLine("Enter two number, will be writen from first number to second number but only odd numbers.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = n1; i < n2; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
        }
        public void answer8()
        {
            Console.WriteLine("Enter your birthday as \"m-d-y\", your age will be written");
            int n1 = Convert.ToInt32(Console.ReadLine().Split("-")[2]);
            int age = Convert.ToInt32(DateTime.Now.ToString("yyyy"))-n1;
            Console.WriteLine("ur age: {0}", age);
        }
        public void answer9()
        {
            Console.WriteLine("Enter two number to multiply");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("answer: {0}", n1 * n2);
        }
        public void answer10()
        {
            Console.WriteLine("Enter five number. Numbers will be added together.");
            int sumOfNumbers = 0;
            for (int i = 0; i < 5; i++)
            {
                sumOfNumbers+=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sum of numbers: {0}", sumOfNumbers);
        }
        public void answer11()
        {
            Console.WriteLine("Enter thirty number. Avarage will be calculated.");
            int sumOfNumbers = 0;
            for (int i = 0; i < 30; i++)
            {
                sumOfNumbers += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("avarage of numbers: {0}", sumOfNumbers/30);
        }
        public void answer12()
        {
            Console.WriteLine("Enter number and later, enter numbers as many number as the entered number. Avarage will be calculated.");
            int number_of_numbers = Convert.ToInt32(Console.ReadLine());
            int sumOfNumbers = 0;
            for (int i = 0; i < number_of_numbers; i++)
            {
                sumOfNumbers += Convert.ToInt32(Console.ReadLine());
            }
            double avg = Convert.ToDouble(sumOfNumbers) / Convert.ToDouble(number_of_numbers);
            Console.WriteLine("avarage of numbers: {0}", avg);
        }
        public void answer13()
        {
            Console.WriteLine("Enter two number sequentially. The bigger will be writed.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2) Console.WriteLine("bigger number: {0}", n1);
            else if (n1 > n2) Console.WriteLine("bigger number: {0}", n2);
            else Console.WriteLine("numbers is equal");
            
        }
        public void answer14()
        {
            Console.WriteLine("Enter a hundered number sequentially. The bigger will be writed.");
            int bigger=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 5; i++)
            {
                int new_number= Convert.ToInt32(Console.ReadLine());
                if(bigger < new_number)
                {
                    bigger = new_number;
                }
            }
            Console.WriteLine("bigger number: {0}", bigger);


        }
        public void answer15()
        {
            Console.WriteLine("Enter a number. And later, enter numbers as many number as the entered number. Bigger will be found.");

            int number_of_numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a hundered number");
            int bigger = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number_of_numbers; i++)
            {
                int new_number = Convert.ToInt32(Console.ReadLine());
                if (bigger < new_number)
                {
                    bigger = new_number;
                }
            }
            Console.WriteLine("bigger number: {0}", bigger);
        }

        public void answer16()
        {
            Console.WriteLine("Enter 50 number. Bigger even number will be found.");
            int bigger = int.MinValue;

            for (int i = 1; i < 7; i++)
            {
                int new_number = Convert.ToInt32(Console.ReadLine());
                if (bigger < new_number && new_number %2==0)
                {
                    bigger = new_number;
                }
            }
            Console.WriteLine("bigger number: {0}", bigger);
        }
        public void answer17()
        {
            Console.WriteLine("Enter a number. Factorial of the number will be found.");
            double factorialOfTheNumber=1;
            int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                factorialOfTheNumber *= i+1;
                Console.WriteLine(factorialOfTheNumber);
            }
            Console.WriteLine("Factoriel of the number: {0}", factorialOfTheNumber);

        }
        public void answer18()
        {
            Console.WriteLine("Enter a number. Fibonacci series smaller than the entered number will be written");
            int number = Convert.ToInt32(Console.ReadLine());
            int value1 = 0, value2 = 1;
            int keep = 0, sum = 1, keep_sum;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(sum+ "aaaaaaaaaa" +keep);
                keep_sum = sum;
                sum = keep + sum;
                keep = keep_sum;

            }
        }
        public void answer19()
        {
            Console.WriteLine("Enter the length of the two short sides of the right triangle. Will be calculte hypotenuse length");
            Console.WriteLine("Side 1:");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side 2:");
            double side2 = Convert.ToDouble(Console.ReadLine());
            double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2);
            Console.WriteLine("hypotenuse: {0}", hypotenuse);
        }


        public void answer20()
        {
            Console.WriteLine("Enter two number, first number will be divided by second num.");
            Console.WriteLine("number 1:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("number 2:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double result = n1/n2;
            Console.WriteLine("result: {0}", result);
        }

        public void answer21()
        {
            Console.WriteLine("Enter two number, the second number will be the power of the first number and thats will be calculated.");
            Console.WriteLine("number 1:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("number 2:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double result=n1;
            
            for (int i = 0; i < n2-1; i++)
            {
                result *= n1;
            }
            Console.WriteLine("result: {0}", result);
        }
        public void answer22()
        {
            Console.WriteLine("Enter 20 birthday date as \"d/m/y\", avarage age will be calculated.");
            int sumOfAge = 0;

            for (int i = 0; i < 20; i++)
            {
                int age;
                DateTime birthday = DateTime.Parse(Console.ReadLine());
                int day = Convert.ToInt32(birthday.ToString("dd"));
                int month = Convert.ToInt32(birthday.ToString("MM"));
                int year = Convert.ToInt32(birthday.ToString("yyyy"));

                int nowday = Convert.ToInt32(DateTime.Now.ToString("dd"));
                int nowmonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
                int nowyear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

                if (nowmonth > month)
                {
                    Console.WriteLine("if");

                    age = nowyear - year;
                }
                else if(nowmonth==month && nowday >= day)
                {
                    Console.WriteLine("else if");

                    age = nowyear - year;
                }
                else
                {
                    Console.WriteLine("else");

                    age = nowyear - year -1;
                }
                sumOfAge += age;
            }
            Console.WriteLine("avarage age is: {0}", sumOfAge / 20);

        }
        public void answer23()
        {
            Console.WriteLine("Enter 100 number, avarage of numbers divisible by 2, 3 and 6 will be calculated.");
            int counter2 = 0, counter3 = 0, counter6 = 0;
            double divisible2 = 0, divisible3 = 0, divisible6 = 0;

            for (int i = 0; i < 100; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number%6==0)
                {
                    counter2++; counter3++; counter6++;
                    divisible2 += number;
                    divisible3 += number;
                    divisible6 += number;
                }
                else if (number % 2==0)
                {
                    counter2++;
                    divisible2 += number;
                }
                else if (number % 3 == 0)
                {
                    counter3++;
                    divisible3 += number;
                }

            }
            double avg2 = divisible2 / counter2;
            double avg3 = divisible3 / counter3;
            double avg6 = divisible6 / counter6;
            Console.WriteLine("avg of divisible by 2: {0}", avg2);
            Console.WriteLine("avg of divisible by 3: {0}", avg3);
            Console.WriteLine("avg of divisible by 6: {0}", avg6);
        }
        public void answer24()
        {
            Console.WriteLine("enter a number and enter as many numbers as you entered, the average will be calculated");
            int number = Convert.ToInt32(Console.ReadLine());
            int sumOfNumbers = 0;
            for (int i = 0; i < number; i++)
            {
                sumOfNumbers+=Convert.ToInt32(Console.ReadLine());
            }
            double avgOfNumbers = Convert.ToDouble(sumOfNumbers) / Convert.ToDouble(number);
            Console.WriteLine("avg of numbers: {0}", avgOfNumbers);

        }
        public void answer25()
        {
            Console.WriteLine("Enter 100 number, avarage of numbers divisible by 2 and 3 will be calculated.");
            int counter6 = 0;
            double divisible6 = 0;
            for (int i = 0; i < 3; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 6==0)
                {
                    counter6++;
                    divisible6 += number;
                }
            }
            double avg6 = divisible6 / counter6;
            Console.WriteLine("avg of divisible by 6: {0}", avg6);
        }
    
        public void answer26()
        {
            int result;
            Console.WriteLine("Enter 3 exam grades. Your result will be returned");
            Console.WriteLine("Exam grade 1");
            double grade1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Exam grade 2");
            double grade2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Exam grade 3");
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double avgGrade= Convert.ToDouble((grade1+grade2+grade3)/3);
            if (avgGrade < 40) result = 1;
            else if (avgGrade >=40 && avgGrade<60) result = 2;
            else if (avgGrade >=60 && avgGrade<75) result = 3;
            else if (avgGrade >=75 && avgGrade < 85) result = 4;
            else if (avgGrade >=85 && avgGrade < 100) result = 5;
            else { Console.WriteLine("ur grades couldn found"); 
                result = 0; }
            Console.WriteLine("ur result: {0}:", result);

        }
        public void answer27()
        {
            Console.WriteLine("Enter a number. Number sign will be returned. ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number>0) { Console.WriteLine("number is positive"); }
            else if(number==0) { Console.WriteLine("number is zero!"); }
            else if(number<0) { Console.WriteLine("number is negative"); }

        }
        public void answer28()
        {
            Console.WriteLine("Enter Fahrenheit. Celsius will be writed.");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celcies= (fahrenheit-32)/1.8;
            Console.WriteLine("Celsius: {0}", celcies);
        }
        public void answer29()
        {
            Console.WriteLine("Enter the temperature of the water. Whether it is solid, liquid or gas ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (temperature <= 0) { Console.WriteLine("solid"); }
            else if (temperature>0 && temperature<100) { Console.WriteLine("liquid"); }
            else if (temperature >= 100) { Console.WriteLine("gas"); }
        }
        public void answer30()
        {
            const double pi = 3.14;
            Console.WriteLine("Enter the radius of the sphere. the volume will be calculated");
            double radius = Convert.ToDouble(Console.ReadLine());
            double volume= (Convert.ToDouble(4)/Convert.ToDouble(3))*pi*radius*radius*radius;
            Console.WriteLine("Volume of the sphere: {0}", volume);
        }


        public void answer31()
        {
            Console.WriteLine("Enter the product price, the total price(with KDV) will be calculated, writed");
            double price = Convert.ToDouble(Console.ReadLine());
            double totalPrice = price+price/100*18;
            Console.WriteLine("total price: {0}", totalPrice);

        }

        public void answer32()
        {
            Console.WriteLine("Enter how many numbers you want to enter. and enter as many " +
                "umbers as you want to enter. If the number of numbers entered is odd," +
                " it will be added and if it is even, it will be multiplied.");
            int numberOfNumbers= Convert.ToInt32(Console.ReadLine());
            int result=0;
            
            if (numberOfNumbers%2==0)
            {
                result = 1;
                for (int i = 0; i < numberOfNumbers; i++)
                    result *= Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                for (int i = 0; i < numberOfNumbers; i++)
                    result += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("result {0}", result);
        }


        public void answer33()
        {
            Console.WriteLine("Enter the number, the numbers from 0 to entered number will be writed");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void answer34()
        {
            Console.WriteLine("Enter the number, ur name will be writed(with while loop)");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (counter != number)
            {
                Console.WriteLine("nahrideb");
                counter++;
            }
        }
        public void answer35()
        {
            Console.WriteLine("Enter the two number, multiplay of these two numbers will be calculated," +
                "without using multiplication ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < number1; i++)
            {
                result += number2;
            }
            Console.WriteLine("result= {0}", result);

        }
        public void answer36()
        {
            Console.WriteLine("Enter the two number, divide of these two numbers will be calculated," +
                "without using division ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            while (sum+number2 < number1)
            {
                sum += number2;
                counter++;
            }
            Console.WriteLine("result= {0}", counter);
        }

        public void answer37()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");


            int size = 9;
            for (int i = 0; i < size; i++)
            {
                int A = (size + 1) / 2;
                for (int k = 0; k < A-i; k++)
                    Console.Write(" ");
                for (int j = A-i; j < A + i +1; j++)
                    Console.Write("*");

                if (A - i <= 0) { break; }
                Console.Write("\n");
            }
            Console.Write("\n\n");
            //------------------------------- shape6---------------------------------//
            size = 9;
            for (int i = 0; i < size; i++)
            {
                int A = (size + 1) / 2;
                for (int k = 0; k < A - i; k++)
                    Console.Write(" ");
                for (int j = A - i; j < A + i + 1; j++)
                    Console.Write("*");

                if (A - i <= 0) { break; }
                Console.Write("\n");
            }
            Console.Write("\n");


            for (int i = 1; i < size; i++)
            {
                int A = (size + 1) / 2;
                int B=-1;
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                    B = k;
                }
                for (int j = B-1; j < size-i; j++)
                    Console.Write("*");



                if (A - i <= 0) { break; }
                Console.Write("\n");
            }
            //------------------------------- shape6---------------------------------//


            int first_star_loc = 0;
            int sec_star_loc = 4;
            size = 5;
            Console.Write("\n");
            for (int a = 0; a < size; a++)
            { Console.Write("*"); }
            Console.Write("\n");
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (k==first_star_loc || k==sec_star_loc)
                    {
                        Console.Write("*");
                    }
                    if (size % 2 == 0)
                        Console.Write(" ");
                    else if(size % 2 == 1)
                    {
                        if(k!=(size-1)/2)
                            Console.Write(" ");
                    }
                }
                first_star_loc++;
                sec_star_loc--;
                Console.Write("\n");
            }

            //------------------------------- shape 4- square---------------------------------//
            int length = 7, width = 10;

            for (int i = 0;i < length; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    bool condition1 = i == 0 || i == length - 1;
                    bool condition2 = k == 0 || k == width - 1;

                    if (condition1 || condition2)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
            //------------------------------- shape 4- square---------------------------------//

            size = 10;
            int control = size;
            for (int i = 0; i < size; i++)
            {
                for (int k = control; k > 0; k--)
                {
                    Console.Write("*");
                }
                control--;
                Console.Write("\n");
            }
            //------------------------------- shape 7- filled square---------------------------------//
            length = 3;
            width = 10;
            for (int i = 0; i < length; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //------------------------------- shape 7- filled square---------------------------------//
            size = 7;
            int locs = (size + 1) / 2;
            for (int i = 1; i < size+1; i++)
            {
                for (int k = 1; k < size+1; k++)
                {
                    Console.Write(' ');
                    if (i == locs || k==locs)
                        Console.Write("*");
                    else 
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
        //------------------------------- 37 22222222222222222222222222222222222222222---------------------------------//

        public void answer37_2()
        {
            Console.WriteLine("enter size for a right triangle");
            int size=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");

            Console.WriteLine("enter size for a pyramid");
            size = Convert.ToInt32(Console.ReadLine())*2-3;
            for (int i = 0; i < size; i++)
            {
                int A = (size + 1) / 2;
                for (int k = 0; k < A - i; k++)
                    Console.Write(" ");
                for (int j = A - i; j < A + i + 1; j++)
                    Console.Write("*");

                if (A - i <= 0) { break; }
                Console.Write("\n");
            }
            Console.Write("\n\n");
            //------------------------------- shape6---------------------------------//
            Console.WriteLine("enter size for a diamond");
            size = Convert.ToInt32(Console.ReadLine()) * 2 - 3;
            for (int i = 0; i < size; i++)
            {
                int A = (size + 1) / 2;
                for (int k = 0; k < A - i; k++)
                    Console.Write(" ");
                for (int j = A - i; j < A + i + 1; j++)
                    Console.Write("*");

                if (A - i <= 0) { break; }
                Console.Write("\n");
            }
            Console.Write("\n");


            for (int i = 1; i < size; i++)
            {
                int A = (size + 1) / 2;
                int B = -1;
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                    B = k;
                }
                for (int j = B - 1; j < size - i; j++)
                    Console.Write("*");



                if (A - i <= 0) { break; }
                Console.Write("\n");
            }
            //------------------------------- shape6---------------------------------//

            Console.WriteLine("enter size for X mark");
            size = Convert.ToInt32(Console.ReadLine());
            int first_star_loc = 0;
            int sec_star_loc = 4;
            Console.Write("\n");
            for (int a = 0; a < size; a++)
            { Console.Write("*"); }
            Console.Write("\n");
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    if (k == first_star_loc || k == sec_star_loc)
                    {
                        Console.Write("*");
                    }
                    if (size % 2 == 0)
                        Console.Write(" ");
                    else if (size % 2 == 1)
                    {
                        if (k != (size - 1) / 2)
                            Console.Write(" ");
                    }
                }
                first_star_loc++;
                sec_star_loc--;
                Console.Write("\n");
            }

            //------------------------------- shape 4- square---------------------------------//
            Console.WriteLine("enter length and width sequentially for a rectangle");
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    bool condition1 = i == 0 || i == length - 1;
                    bool condition2 = k == 0 || k == width - 1;

                    if (condition1 || condition2)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
            //------------------------------- shape 4- square---------------------------------//
            Console.WriteLine("enter size reverse right triangle");
            size = Convert.ToInt32(Console.ReadLine());
            int control = size;
            for (int i = 0; i < size; i++)
            {
                for (int k = control; k > 0; k--)
                {
                    Console.Write("*");
                }
                control--;
                Console.Write("\n");
            }
            //------------------------------- shape 7- filled square---------------------------------//
            Console.WriteLine("enter length and width sequentially for a filled rectangle");
            length = Convert.ToInt32(Console.ReadLine());
            width = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            //------------------------------- shape 7- filled square---------------------------------//
            Console.WriteLine("enter size for plus + mark");
            size = Convert.ToInt32(Console.ReadLine());
            int locs = (size + 1) / 2;
            for (int i = 1; i < size + 1; i++)
            {
                for (int k = 1; k < size + 1; k++)
                {
                    Console.Write(' ');
                    if (i == locs || k == locs)
                        Console.Write("*");
                    else
                        Console.Write(' ');
                }
                Console.Write("\n");
            }
        }


        public void answer38()
        {
            Console.WriteLine("Enter two number, even numbers betweetn these two numbers will be writen");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp;
            if (number2 > number1)
            {
                temp = number2;
                number2 = number1;
                number1 = temp;
            }
            else if (number2 == number1)
                Console.WriteLine("girilen sayilar birbirinden farkli olmali...  :(");
            int start = number2;
            if (number2 % 2 == 1)
                start += 1;
            for (int i = start; i < number1;)
            {
                Console.WriteLine(i);
                i += 2;
            }


            Console.WriteLine("result= {0}");
        }
        public void answer39()
        {
            Console.WriteLine("Enter 1000 number, numbers will be writen,");
            int[] array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }


        public void answer40()
        {
            Console.WriteLine("Enter 100 number, will be found even and odd numbers and will be writen to the screen.");
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            int enteredNumber;
            for (int i = 0; i < 20; i++)
            {
                enteredNumber = Convert.ToInt32(Console.ReadLine());
                if (enteredNumber % 2 == 1)
                {
                    oddNumbers.Add(enteredNumber);
                }
                else if (enteredNumber % 2 == 0)
                {
                    evenNumbers.Add(enteredNumber);

                }
            }
            Console.WriteLine("Odd Numbers:");
            foreach (int item in oddNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Even Numbers:");
            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }

        }
        public void answer41()
        {
            Console.WriteLine("Enter a number, and enter numbers as many number as entered number. " +
                " entered numbers under the average will be calculated,");
            int number=Convert.ToInt32(Console.ReadLine());
            List<int> Numbers = new List<int>();
            int sumOfNumbers =0;
            for (int i = 0; i < number; i++)
            {
                int entered=Convert.ToInt32(Console.ReadLine());
                Numbers.Add(entered);
                sumOfNumbers+=entered;
            }
            double avg= Convert.ToDouble(sumOfNumbers)/number;
            foreach (double num in Numbers)
            {
                if (num<avg)
                {
                    Console.WriteLine("number: {0}  AVG: {1}", num, avg);
                }
            }
            int number2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("result= {0}");
        }
        public void answer42()
        {
            Console.WriteLine("Enter a number, and enter numbers as many number as entered number. " +
                "reverse of input numbers will be writen");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(array[1]);
            for (int i = number-1; i >= 0; i--)
            {
                Console.WriteLine("number {0}: {1}", i ,array[i]);
            }

        }
        public void answer43()
        {
            Console.WriteLine("Enter VIZE grade, and FINAL grade. Ur result will be calculated.");
            double VIZE = Convert.ToDouble(Console.ReadLine());
            double FINAL = Convert.ToDouble(Console.ReadLine());
            double AVG=(VIZE*4/10)+(FINAL*6/10);
            if (AVG >= 50)
            {
                Console.WriteLine("Succesfull. U passed!");
            }
            else if (AVG < 50)
            {
                Console.WriteLine("Unsuccessful. Enter BUT grade!");
                double BUT = Convert.ToDouble(Console.ReadLine());
                AVG = (VIZE * 4 / 10) + (BUT * 6 / 10);
                if (AVG >= 50)
                {
                    Console.WriteLine("Succesfull. U passed!");
                }
                else
                    Console.WriteLine("Unsuccessful. Try it again next year :(");
            }
        }
        public void answer44()
        {
            Console.WriteLine("Matris sum:");
            int[,] matris1 = { { 1, 2,3 }, { 3,3, 4 }, { 5, 6,3 }, { 7,3, 8 } };
            int[,] matris2 = { { 1, 1, 1 }, { 1,3, 0 }, { 0, 0, 0 }, { 2,2, 1 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matris1[i, j] + matris2[i, j]+" ");
                }
                Console.Write("\n");
            }
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("result= {0}");
        }
        public void answer45()
        {
            Console.WriteLine("Matris multlipication:");
            int[,] matris1 = { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 } };
            int[,] matris2 = { { 3, 1, 5, 0 }, { 0, 0, 1, 2 } };
            int[,] sumMatris = new int[matris1.GetLength(0), matris2.GetLength(1)];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        sumMatris[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(sumMatris[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

    }
}
