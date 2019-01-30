using System;

namespace Calculators
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();

            Console.WriteLine("Input two numbers to add: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());            

            Console.WriteLine(
                "Result: " + 
                Calc.Add(a, b) +
                "\n" +
                "--------------" +
                "\n"
            );

            Console.WriteLine("Input two numbers to subtract: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());            

            Console.WriteLine(
                "Result: " + 
                Calc.Subtract(a, b) +
                "\n" +
                "--------------" +
                "\n"
            );

            Console.WriteLine("Input two numbers to multiply: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());            

            Console.WriteLine(
                "Result: " + 
                Calc.Multiply(a, b) +
                "\n" +
                "--------------" +
                "\n"
            );

            Console.WriteLine("Input two numbers to exponentialize (yes it's a word): ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());            

            Console.WriteLine(
                "Result: " + 
                Calc.Power(a, b) +
                "\n" +
                "--------------" +
                "\n"
            );
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }
}
