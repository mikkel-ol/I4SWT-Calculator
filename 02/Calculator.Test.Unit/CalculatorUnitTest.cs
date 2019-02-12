using NUnit.Framework;
using Calculators;

namespace Tests
{
    public class CalculatorUnitTest
    {
        private Calculator Calc;

        [SetUp]
        public void Setup()
        {
            Calc = new Calculator();
        }

        [TestCase(10, 20, 30)]
        [TestCase(-2, -4, -6)]
        [TestCase(-2, 4, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 1)]
        [TestCase(0, -1, -1)]
        [TestCase(1.5, 2.4, 3.9)]
        [TestCase(-1.15, 1.3, 0.15)]
        public void TestAdd(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Add(a, b)).Within(.1));
        }

        [TestCase(10, 20, -10)]
        [TestCase(-2, -4, 2)]
        [TestCase(-2, 4, -6)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, -1)]
        [TestCase(0, -1, 1)]
        [TestCase(1.5, 2.4, -.9)]
        [TestCase(-1.15, 1.3, -2.45)]
        public void TestSubtract(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Subtract(a, b)).Within(.1));
        }

        [TestCase(10, 20, 200)]
        [TestCase(-2, -4, 8)]
        [TestCase(-2, 4, -8)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(1.5, 2.4, 3.6)]
        [TestCase(-1.15, 1.3, -1.495)]
        public void TestMultiply(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Multiply(a, b)).Within(.1));
        }

        [TestCase(1, 0, 1)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 27)]
        [TestCase(1.5, 2.4, 2.64)]
        [TestCase(-2, -2 , .25)]
        public void TestPower(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Power(a, b)).Within(.1));
        }

        public void TestDivide(double a, double b, double result)
        {
            Assert.Throws<CalculatorException>(Calc.Divide(a,b));
        }
    }
}