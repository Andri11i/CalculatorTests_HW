using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_HW
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

        public double Average(double[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array cannot be empty.");
            return numbers.Average();
        }

        public double Max(double[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array cannot be empty.");
            return numbers.Max();
        }

        public double[] Sort(double[] numbers) => numbers.OrderBy(n => n).ToArray();
    }

}
