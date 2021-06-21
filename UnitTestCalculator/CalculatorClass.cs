using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Class containing functions to be used by a calculator
//Name: Lukas Jehle
//Student ID: #20009320
//Assignment: 2

namespace UnitTestProjectCalculator
{
    public class CalculatorClass
    {
        //returns addition of two numbers in string format
        public string Add(double num1, double num2)
        {
            return Convert.ToString(num1 + num2);

        }
        //returns subtraction of two numbers in string format
        public string Subtract(double minuend, double subtrhend)
        {
            return Convert.ToString(minuend - subtrhend);
        }
        //returns multiplication of two numbers in string format
        public string Multiply(double num1, double num2)
        {
            return Convert.ToString(num1 * num2);
        }
        //returns division of two numbers in string format
        public string Divide(double dividend, double divisor)
        {
            if (divisor != 0) { return Convert.ToString(dividend / divisor); }
            return "Cannot divide by zero";
        }
        //returns square root of a number in string format
        public string SquareRoot(double num)
        {
            double sqRoot;
            if (num >= 0)
            {
                sqRoot = Math.Sqrt(num);
                return Convert.ToString(sqRoot) + " and -" + Convert.ToString(sqRoot);
            }
            else
            {
                sqRoot = Math.Sqrt(Math.Abs(num));
                return Convert.ToString(sqRoot) + "i" + " and -" + Convert.ToString(sqRoot) + "i";
            }
        }

        //returns square root of a number in array of Complex Class format
        public Complex[] SquareRootArray(double num)
        {
            double sqRoot;
            if (num >= 0)
            {
                sqRoot = Math.Sqrt(num);
                Complex[] realArray =
                {
                    new Complex(sqRoot, 0),
                    new Complex(-sqRoot, 0)
                };
                return realArray;

            }
            else
            {
                sqRoot = Math.Sqrt(Math.Abs(num));
                Complex[] imaginaryArray =
                {
                    new Complex(0, sqRoot),
                    new Complex(0, -sqRoot)
                };
                return imaginaryArray;
            }
        }

    }
}
