using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        
        [TestMethod()]
        public void AddTest()
        {
            var calculator = new Class1();
            double x = 5;
            double y = 10;
            Assert.AreEqual(15, calculator.Add(x, y));
        }

        [TestMethod()]
        public void SubTest()
        {
            var calculator = new Class1();
            double x = 5;
            double y = 10;
            Assert.AreEqual(-5, calculator.Sub(x, y));
        }

        [TestMethod()]
        public void MulTest()
        {
            var calculator = new Class1();
            double x = 5;
            double y = 10;
            Assert.AreEqual(50, calculator.Mul(x, y));
        }

        [TestMethod()]
        public void DivTest()
        {
            var calculator = new Class1();
            double x = 10;
            double y = 5;
            Assert.AreEqual(2, calculator.Div(x, y));
        }
    }
}