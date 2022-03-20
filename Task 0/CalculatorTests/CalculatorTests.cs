using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            double x = 5;
            double y = 10;
            var calculator = new Calculator();
            Assert.AreEqual(15, calculator.Add(x, y));
        }

        [TestMethod]
        public void SubTest()
        {
            double x = 5;
            double y = 10;
            var calculator = new Calculator();
            Assert.AreEqual(-5, calculator.Sub(x, y));
        }

        [TestMethod]
        public void MulTest()
        {
            double x = 5;
            double y = 10;
            var calculator = new Calculator();
            Assert.AreEqual(50, calculator.Mul(x, y));
        }

        [TestMethod]
        public void DivTest()
        {
            double x = 5;
            double y = 10;
            var calculator = new Calculator();
            Assert.AreEqual(0.5, calculator.Div(x, y));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivByZeroTest()
        {
            double x = 5;
            double y = 0;
            var calculator = new Calculator();
            calculator.Div(x, y);
        }
    }
}