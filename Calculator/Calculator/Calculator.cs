using System;

namespace Calculators
{
    public class Calculator
    {
        public Calculator() => Clear();

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

            Console.WriteLine("Input two numbers to exponentialize: ");
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

        // Simple
        public double Add(double a, double b)
        {
            return a + b;
        }
        // Using Accumulator
        public double Add(double addend)
        {
            return Accumulator += addend;
        }

        // Simple
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        // Using Accumulator
        public double Subtract(double subtractor)
        {
            return Accumulator -= subtractor;
        }

        // Simple
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        // Using Accumulator
        public double Multiply(double multiplier)
        {
            return Accumulator *= multiplier;
        }

        // Simple
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
        // Using Accumulator
        public double Power(double exponent)
        {
            return Accumulator = Math.Pow(Accumulator, exponent);
        }

        // Simple
        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0) throw new CalculatorException(divisor);
            return dividend / divisor;
        }
        // Using Accumulator
        public double Divide(double divisor)
        {
            if (divisor == 0) throw new CalculatorException(divisor);
            return Accumulator = Accumulator / divisor;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }
    }

}

