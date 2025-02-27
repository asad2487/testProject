using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Calculator
    {
        //added for testing

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
        // Method to demonstrate nullable warning
        public string? GetGreetingMessage(string? name)
        {
            // Warning: 'name' can be null
            if (name == null)
            {
                Console.WriteLine("Name is null.");
                return null;
            }

            return $"Hello, {name}!";
        }

        // Method to demonstrate nullable reference types with collection
        public List<string?> GetNamesWithNullability(List<string>? names)
        {
            // Warning: 'names' can be null
            if (names == null)
            {
                Console.WriteLine("Names list is null.");
                return new List<string?>();
            }

            // Adding a nullable element to the list for testing
            names.Add(null); // Warning: we added a null to a non-nullable collection
            return names;
        }
    }
}
