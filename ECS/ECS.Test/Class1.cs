using NUnit.Framework;
using ECSSWT;

//#######################################
//
// Microsoft: Using Stubs to isolate parts of your application
// from each other for unit testing
//
// https://docs.microsoft.com/en-us/visualstudio/test/using-stubs-to-isolate-parts-of-your-application-from-each-other-for-unit-testing?view=vs-2017
//
//########################################
namespace ECS.Test
{
    [TestFixture]
    public class HeaterTest
    {
        // Objects pref. interfaces
        

        [SetUp] // https://github.com/nunit/docs/wiki/Attributes
        public void setup()
        {
            // setup Using interfaces
            ISensor fakeTempSensor = new FakeTempSensor();
            IHeater fakeHeater = new FakeHeater();
            ECS uut = new ECS(22, fakeTempSensor, fakeHeater);

        }

        [TestCase(1,2,3,TestName ="CaseOne")]
        public void TestTest(double a, double b, double result)
        {
            Assert.That(result, Is.EqualTo(1 + 2));
        }
/* [Random(-1,2,5)]
 * [Values(1,2,3,4,5,)]
 * 
        [TestCase(Values(1, 2, 3, 4),Random(-1, -2, 4), TestName = "bb")]
        public void Test_Values_Random( double a, double b)
        {
            double result = a + b;
            Assert.That(result, Is.EqualTo(a+b));
        }
        
*/


        

    }
}
