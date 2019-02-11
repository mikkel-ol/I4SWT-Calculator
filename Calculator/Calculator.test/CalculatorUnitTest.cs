using NUnit.Framework;
using Calculators;

namespace Calculators.test
{
    public class CalculatorUnitTest
    {
        private Calculator Calc;

        [SetUp]
        public void Setup()
        {

            Calc = new Calculator();
        }

        [TestCase(10, 20, 30, TestName = "Method_Add_Positive_Result_Positive")]
        [TestCase(-2, -4, -6, TestName = "Method_Add_Negative_Result_Negative")]
        [TestCase(-2, 4, 2, TestName = "Method_Add_PosNeg_Result_Pos")]
        [TestCase(0, 0, 0, TestName = "Method_Add_Zero_Result_Zero")]
        [TestCase(0, 1, 1, TestName = "Method_Add_One_to_Zero_Result_One")]
        [TestCase(0, -1, -1, TestName = "Method_Add_NegOne_to_Zero_Result_NegOne")]
        [TestCase(1.5, 2.4, 3.9, TestName = "Method_Add_Odd_to_Odd_Result_Odd_DELTA_POINT_ONE")]
        [TestCase(-1.15, 1.3, 0.15, TestName = "Method_Add_NegOdd_to_PosOdd_Result_Odd_DELTA_POINT_ONE")]
        public void TestAdd(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Add(a, b)).Within(.1));
        }

        [TestCase(10, 20, -10, TestName = "Method_Subtract_Pos_by_Pos_Result_Neg")]
        [TestCase(-2, -4, 2, TestName = "Method_Subtract_neg_by_Neg_Result_Pos")]
        [TestCase(-2, 4, -6, TestName = "Method_Subtract_Neg_by_Pos_Result_Neg")]
        [TestCase(0, 0, 0, TestName = "Method_Subtract_Zero_by_Zero_Result_Zero")]
        [TestCase(0, 1, -1, TestName = "Method_Subtract_Zero_by_One_Result_NegOne")]
        [TestCase(0, -1, 1, TestName = "Method_Subtract_Zero_by_NegOne_Result_One")]
        [TestCase(1.5, 2.4, -.9, TestName = "Method_Subtract_Odd_by_Odd_Result_NegOdd_DELTA_POINT_ONE")]
        [TestCase(-1.15, 1.3, -2.45, TestName = "Method_Subtract_NegOdd_by_PosOdd_Result_NegOdd_DELTA_POINT_ONE")]
        public void TestSubtract(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Subtract(a, b)).Within(.1));
        }

        [TestCase(10, 20, 200, TestName = "Method_Multiply_Pos_by_Pos_Result_Pos")]
        [TestCase(-2, -4, 8, TestName = "Method_Multiply_Neg_by_Neg_Result_Pos")]
        [TestCase(-2, 4, -8, TestName = "Method_Multiply_Neg_by_Pos_Result_Neg")]
        [TestCase(0, 0, 0, TestName = "Method_Multiply_Zero_by_Zero_Result_Zero")]
        [TestCase(0, 1, 0, TestName = "Method_Multiply_Zero_by_Pos_Result_Zero")]
        [TestCase(0, -1, 0, TestName = "Method_Multiply_Zero_by_Neg_Result_Zero")]
        [TestCase(1.5, 2.4, 3.6, TestName = "Method_Multiply_Odd_by_Odd_Result_PosOdd_DELTA_POINT_ONE")]
        [TestCase(-1.15, 1.3, -1.495, TestName = "Method_Multiply_NegOdd_by_Odd_Result_NegOdd_DELTA_POINT_ONE")]
        public void TestMultiply(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Multiply(a, b)).Within(.1));
        }

        [TestCase(1, 0, 1, TestName = "Method_Power_One_in_Zero_Result_One")]
        [TestCase(0, 1, 0, TestName = "Method_Power_Zero_in_One_Result_Zero")]
        [TestCase(1, 1, 1, TestName = "Method_Power_One_in_One_Result_One")]
        [TestCase(1, 2, 1, TestName = "Method_Power_One_in_Two_Result_One")]
        [TestCase(2, 2, 4, TestName = "Method_Power_Two_in_Two_Result_One")]
        [TestCase(3, 3, 27, TestName = "Method_Power_3_by_3_Result_27")]
        [TestCase(1.5, 2.4, 2.64, TestName = "Method_Power_Odd_by_Odd_Result_Odd_DELTA_POINT_ONE")]
        [TestCase(-2, -2, .25, TestName = "Method_Power_Neg2_by_Neg2_Result_NegOdd_DELTA_POINT_ONE")]
        public void TestPower(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(Calc.Power(a, b)).Within(.1));
        }

        [TestCase(3,0, Author = "SHN", TestName = "Method_Divide_Pos_by_Zero_Throws_EXCEPTION",Reason ="Throws zero Division")]
        public void TestDivide(double a, double b)
        {
            Assert.That(() => Calc.Divide(a, b), Throws.TypeOf<CalculatorException>());
        }
        // () => 
        // is a delegate
        // http://nunit.org/nunitv2/docs/2.6/exceptionAsserts.html
        // alternativt : Assert.Throws<CalculatorException>(() => Calc.Divide(a, b));

        [TestCase(1,2,5, Author ="SHN" ,TestName = "Test50")]
        public void TestAccumulator(double a, double b, double result)
        {
            Calc.Clear();
            Calc.Add(a);
            Calc.Add(b);
            Assert.That(result, Is.EqualTo(Calc.Add(b)));
        }

    }
}