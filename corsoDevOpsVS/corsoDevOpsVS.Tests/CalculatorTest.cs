using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace corsoDevOpsVS.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrangiati
            int a = 5;
            int b = 4;
            int expected = 9;

            //Activati
            int actual = new Calculator().Add(a, b);

            //Assertati
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractTest()
        {
            //Arrangiati
            int a = 5;
            int b = 4;
            int expected = 1;

            //Activati
            int actual = new Calculator().Subtract(a, b);

            //Assertati
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            //Arrangiati
            int a = 5;
            int b = 4;
            int expected = 20;

            //Activati
            int actual = new Calculator().Multiply(a, b);

            //Assertati
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            //Arrangiati
            int a = 5;
            int b = 4;
            int expected = 1;

            //Activati
            int actual = new Calculator().Divide(a, b);

            //Assertati
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void DivideByZeroTest()
        {
            //Arrangiati
            int a = 5;
            int b = 0;
            int expected = 1;

            //Activati
            int actual = new Calculator().Divide(a, b);

            //Assertati
            //Assert.AreEqual(expected, actual);
        }
    }


}
