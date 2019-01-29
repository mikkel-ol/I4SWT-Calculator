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

        [Test]
        public void TestAdd1()
        {
            Assert.That(1000, Is.EqualTo(Calc.Add(1001, -1)));
        }
    }
}