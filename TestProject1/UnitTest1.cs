using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calculator = new Calculator();

            double res = calculator.sum(1.5f, 2.5f);

            Assert.AreEqual(res, 4f);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator calculator = new Calculator();

            double res = calculator.sum(1.5f, -2.5f);

            Assert.AreEqual(res, -1f);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculator calculator = new Calculator();

            double res = calculator.sum(-1.5f, -2.5f);

            Assert.AreEqual(res, -4f);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Calculator calculator = new Calculator();

            double res = calculator.sum(-1.5f, 2.5f);

            Assert.AreEqual(res, 1f);
        }
    }
}
