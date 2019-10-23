using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyUtilities;

namespace MyUtilitiesTest.GeneratorNumberTest
{
    [TestClass]
    public class GeneratorNumberTest
    {
        [TestMethod]
        public void CheckGenerator_True_Result()
        {
            // arrange
            int one = 1;
            int two = 2;

            // act
            GeneratorNumber generator = new GeneratorNumber();
            bool actual = generator.CheckGenerator(one, two);

            //assert
            Assert.IsTrue(actual);
        }
    }
}
