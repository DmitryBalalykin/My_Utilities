using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyUtilities;

namespace MyUtilitiesTest.CounterTest
{
    [TestClass]
    public class CounterTest
    {
        Counter counter = new Counter();

        [TestMethod]
        public void Discharge_0Return()
        {
            //arrange
            const string label = "null";
            const string expected = "0";

            //act

            string actual = counter.Discharge(label);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Decrease_Number_minus_one_Result_Return()
        {
            //arrange
            const string number = "2";
            const int expected = 1;

            // act
            int actual = counter.Decrease(number);

            // assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IncreaseNumber_Number_plus_one_Result_Return()
        {
            //arrange
            const string number = "2";
            const int expected = 3;

            //act
            int actual = counter.IncreaseNumber(number);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
