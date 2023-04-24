using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FractionLibrary;

namespace A8Tests
{
    [TestClass]
    public class FractionTests
    {

        //1, 2 & 3 – Constructor. You must test the three cases: creating a fraction with two ints, with one int and with no argument
        //arrange
        //declare and suitably initialise two int: expectedTop and expectedBottom

        //act
        //create a fraction using the above two arguments

        //assert
        //compare the expectedTop with the Top property of the above object
        //compare the expectedBottom with the Bottom property of the above fraction
        [TestMethod]
        public void Constructor_WithTwoInts()
        {
            //arrange
            int expectedTop = 20;
            int expectedBottom = 10;
            //act
            Fraction f = new Fraction(20, 10);
            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod]
        public void Constructor_WithOneInt()
        {
            int expectedTop = 20;
            int expectedBottom = 1;
            //act
            Fraction f = new Fraction(20);
            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }
        
        [TestMethod]
        public void Constructor_WithZeroArgument()
        {
            //arrange
            int expectedTop = 0, expectedBottom = 1;
            //act
            Fraction f = new Fraction();
            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        //4 – ToString.
        //arrange
        //declare and initialise two ints
        //declare the variable expectedString that will depend on your ToString() method.

        //act
        //declare and create an object using the above two ints

        //assert
        //compare the expectedString variable to the actual output of the ToString() method
        [TestMethod]
        public void Constructor_ToString()
        {
            //arrange
            int expectedTop = 10, expectedBottom = 20;
            string expectedString = $"Top: {expectedTop}, bottom: {expectedBottom}";
            //act
            Fraction f = new Fraction(10, 20);
            //assert
            Assert.AreEqual(expectedString, f.ToString());
        }

        //5 – Addition.
        [TestMethod]
        public void Constructor_Addition()
        {
            //arrange
            int expectedTop = 11, expectedBottom = 10;
            //act
            Fraction f1 = new Fraction(3,5);
            Fraction f2 = new Fraction(1,2);
            Fraction f = f1 + f2;
            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }
        //6 – Subtraction without exception.
        [TestMethod]
        public void Constructor_Difference()
        {
            //arrange
            int expectedTop = 1, expectedBottom = 10;
            //act
            Fraction f1 = new Fraction(3, 5);
            Fraction f2 = new Fraction(1, 2);
            Fraction f = f1 - f2;
            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }
        //7 - Subtraction with exception.
        [TestMethod]
        public void Constructor_DifferenceWithExcemption()
        {
            //arrange
            int expectedTop = -1, expectedBottom = 10;
            //act
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(3, 5);
            Fraction f = f1 - f2;
            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }
    }
}
