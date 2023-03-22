using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PracticeModul16.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(100, 2) == 98);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(100, 2) == 50);
        }

        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(7, 0));
        }

        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(45, 15) == 60);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(8, 5) == 40);
        }
    }
}
