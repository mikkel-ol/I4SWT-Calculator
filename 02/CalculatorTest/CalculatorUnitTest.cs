using NUnit.Framework;
using Calculators;

namespace Tests
{
    public class CalculatorUnitTest
    {
        private Calculator Calc;
        static Calculator Cal= new Calculator();
        public delegate double AccumulateMethod(double param);

        [SetUp]
        public void Setup()
        {

            Calc = new Calculator();
        }

        [TestCase(10, 20, 30, TestName = "Test1")]
        [TestCase(-2, -4, -6, TestName = "Test2")]
        [TestCase(-2, 4, 2, TestName = "Test3")]
        [TestCase(0, 0, 0, TestName = "Test4")]
        [TestCase(0, 1, 1, TestName = "Test5")]
        [TestCase(0, -1, -1, TestName = "Test6")]
        [TestCase(1.5, 2.4, 3.9, TestName = "Test7")]
        [TestCase(-1.15, 1.3, 0.15, TestName = "Test8")]
        [TestCase(1,1,2, TestName = "Test9")]
        public void TestAdd(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Add(a, b)).Within(.1));
        }

        [TestCase(10, 20, -10, TestName = "Test10")]
        [TestCase(-2, -4, 2, TestName = "Test11")]
        [TestCase(-2, 4, -6, TestName = "Test12")]
        [TestCase(0, 0, 0, TestName = "Test13")]
        [TestCase(0, 1, -1, TestName = "Test14")]
        [TestCase(0, -1, 1, TestName = "Test15")]
        [TestCase(1.5, 2.4, -.9, TestName = "Test16")]
        [TestCase(-1.15, 1.3, -2.45, TestName = "Test17")]
        public void TestSubtract(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Subtract(a, b)).Within(.1));
        }

        [TestCase(10, 20, 200, TestName = "Test20")]
        [TestCase(-2, -4, 8, TestName = "Test21")]
        [TestCase(-2, 4, -8, TestName = "Test22")]
        [TestCase(0, 0, 0, TestName = "Test23")]
        [TestCase(0, 1, 0, TestName = "Test24")]
        [TestCase(0, -1, 0, TestName = "Test25")]
        [TestCase(1.5, 2.4, 3.6, TestName = "Test26")]
        [TestCase(-1.15, 1.3, -1.495, TestName = "Test27")]
        public void TestMultiply(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Multiply(a, b)).Within(.1));
        }

        [TestCase(1, 0, 1, TestName ="Test30")]
        [TestCase(0, 1, 0, TestName = "Test31")]
        [TestCase(1, 1, 1, TestName = "Test32")]
        [TestCase(1, 2, 1, TestName = "Test33")]
        [TestCase(2, 2, 4, TestName = "Test34")]
        [TestCase(3, 3, 27, TestName = "Test35")]
        [TestCase(1.5, 2.4, 2.64, TestName = "Test36")]
        [TestCase(-2, -2, .25, TestName = "Test37")]
        public void TestPower(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Power(a, b)).Within(.1));
        }

        [TestCase(3,0, Author = "SHN", TestName = "Test40",Reason ="Throws zero Division")]
        public void TestDivide(double a, double b)
        {
            Assert.That(() => Calc.Divide(a, b), Throws.TypeOf<CalculatorException>());
        }
        // () => 
        // is a delegate
        // http://nunit.org/nunitv2/docs/2.6/exceptionAsserts.html
        // alternativt : Assert.Throws<CalculatorException>(() => Calc.Divide(a, b));

        [TestCase(1,2,5, Author ="SHN" ,TestName = "Test50" ,ExpectedResult ="5")]
        public void TestAccumulator(double a, double b, double result)
        {
            Calc.Clear();
            Calc.Add(a);
            Calc.Add(b);
            Assert.That(result, Is.EqualTo(Calc.Add(b)));
        }

    }
}