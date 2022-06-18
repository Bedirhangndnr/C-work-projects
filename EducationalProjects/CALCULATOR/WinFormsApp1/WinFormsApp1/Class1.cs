using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Arithmetic_Operations
    {
        public double Mod(double value1, double value2 )
        {
            return value1 % value2;
        }
        public void CE()
        {
           
        }
        public double One_Div_value(double value1)
        {
            return 1 / value1;
        }
        public double Square(double value1)
        {
            return value1*value1;
        }
        public double Square_Root(double value1)
        {
            return Math.Sqrt(value1);
        }
        public double Divide(double value1, double value2)
        {
            return value1/value2;
        }
        public double Multiple(double value1, double value2)
        {
            return value1*value2;
        }
        public double Minus(double value1, double value2)
        {
            return value1 - value2;
        }
        public double Plus(double value1, double value2)
        {
            return value1 + value2;
        }
        public double Reverse_Sign(double value1)
        {
            return (-1)*value1;
        }
        public double _2nd(double value1)
        {
            int result = 1;
            for (int i = 0; i < value1; i++)
            {
                result *= 2;
            }
            return result;
        }
        public double xupy(double value1, double value2)
        {
            double result = 1;
            for (int i = 0; i < value2; i++)
            {
                result *= value1;
            }
            return result;
        }
        public double _10upx(double value1)
        {
            double result = 1;
            for (int i = 0; i < value1; i++)
            {
                result *= 10;
            }
            return result;
        }
        public double ln(double value1)
        {
            return Math.Log(value1);
        }
        public double log(double value1)
        {
            return Math.Log10(value1);

        }
        public double abs(double value1)
        {
            if (value1 < 0)
                return -value1;
            return value1;
        }
        public double fact(double value1)
        {
            double result = 1;
            for (int i = 1; i <= value1; i++)
            {
                result *= i;
            }
            return result;
        }

    }
}
