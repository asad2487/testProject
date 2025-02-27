using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Calculator
    {
        // Method to add two numbers
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to subtract two numbers
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Method to multiply two numbers
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Method to divide two numbers
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN;
            }
            return a / b;
        }
    }
}
