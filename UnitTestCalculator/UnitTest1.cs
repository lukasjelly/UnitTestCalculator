using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;

//Unit test project that tests functions within ClassCalculator class
//Name: Lukas Jehle
//Student ID: #20009320
//Assignment: 2

namespace UnitTestProjectCalculator
{
    //Test calculator with positive input//////////////////////////////////////////
    [TestClass]
    public class UnitTestPositiveInput
    {
        //Test addition function computes correctly
        [TestMethod]
        public void TestMethodAdd()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "4";
            string actual = calculation.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        //Test subtraction function computes correctly
        [TestMethod]
        public void TestMethodSubtract()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "2";
            string actual = calculation.Subtract(4, 2);
            Assert.AreEqual(expected, actual);
        }

        //Test multiplication function computes correctly
        [TestMethod]
        public void TestMethodMultiply()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "4";
            string actual = calculation.Multiply(2, 2);
            Assert.AreEqual(expected, actual);
        }

        //Test division function performs computes correctly with zero divisor
        [TestMethod]
        public void TestMethodDivideZeroDivisor()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "Cannot divide by zero";
            string actual = calculation.Divide(4, 0);
            Assert.AreEqual(expected, actual);
        }

        //Test division function computes correctly with non zero divisor
        [TestMethod]
        public void TestMethodDivideNonZeroDivisor()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "4";
            string actual = calculation.Divide(4, 1);
            Assert.AreEqual(expected, actual);
        }

        //Test square root function computes correctly
        [TestMethod]
        public void TestMethodSquareRoot()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "2 and -2";
            string actual = calculation.SquareRoot(4);
            Assert.AreEqual(expected, actual);
        }

        //Test square root function computes correctly decimal points
        [TestMethod]
        public void TestMethodSquareRootDecimal()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "2.82842712474619 and -2.82842712474619";
            string actual = calculation.SquareRoot(8);
            Assert.AreEqual(expected, actual);
        }

        //Test square root function computes correctly with array of Complex Class
        [TestMethod]
        public void TestMethodSquareRootComplex()
        {
            CalculatorClass calculation = new CalculatorClass();
            Complex[] expected =
            {
                new Complex(2, 0),
                new Complex(-2, 0)
            };
            Complex[] actual = calculation.SquareRootArray(4);
            CollectionAssert.AreEqual(expected, actual);
        }
    }

    //Test calculator with negative input//////////////////////////////////////////
    [TestClass]
    public class UnitTestNegativeInput
    {
        //Test addition function computes correctly
        [TestMethod]
        public void TestMethodAdd()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "-4";
            string actual = calculation.Add(-2, -2);
            Assert.AreEqual(expected, actual);
        }

        //Test subtraction function computes correctly
        [TestMethod]
        public void TestMethodSubtract()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "-2";
            string actual = calculation.Subtract(-4, -2);
            Assert.AreEqual(expected, actual);
        }

        //Test multiplication function computes correctly
        [TestMethod]
        public void TestMethodMultiply()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "-4";
            string actual = calculation.Multiply(-2, 2);
            Assert.AreEqual(expected, actual);
        }

        //Test division function computes correctly with zero divisor
        [TestMethod]
        public void TestMethodDivideZeroDivisor()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "Cannot divide by zero";
            string actual = calculation.Divide(-4, 0);
            Assert.AreEqual(expected, actual);
        }

        //Test division function computes correctly with non zero divisor
        [TestMethod]
        public void TestMethodDivideNonZeroDivisor()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "-4";
            string actual = calculation.Divide(-4, 1);
            Assert.AreEqual(expected, actual);
        }

        //Test square root function computes correctly
        [TestMethod]
        public void TestMethodSquareRoot()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "2i and -2i";
            string actual = calculation.SquareRoot(-4);
            Assert.AreEqual(expected, actual);
        }

        //Test square root function computes correctly decimal points
        [TestMethod]
        public void TestMethodSquareRootDecimal()
        {
            CalculatorClass calculation = new CalculatorClass();
            string expected = "2.82842712474619i and -2.82842712474619i";
            string actual = calculation.SquareRoot(-8);
            Assert.AreEqual(expected, actual);
        }

        //Test square root function computes correctly with array of Complex Class
        [TestMethod]
        public void TestMethodSquareRootComplex()
        {
            CalculatorClass calculation = new CalculatorClass();
            Complex[] expected =
            {
                new Complex(0, 2),
                new Complex(0, -2)
            };
            Complex[] actual = calculation.SquareRootArray(-4);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
