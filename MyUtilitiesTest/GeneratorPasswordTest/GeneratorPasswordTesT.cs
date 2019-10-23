using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyUtilities.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilitiesTest.GeneratorPasswordTest
{
    [TestClass]
    public class GeneratorPasswordTesT
    {
        [TestMethod]
        public void CheckListBoxTest_Return_Result_Bool()
        {
            // arange
            const int checed = 2;

            //Act
            GeneratorPassword generatorPassword = new GeneratorPassword();
            bool result = generatorPassword.CheckListBox(checed);

            //assert
            Assert.IsTrue(result);
        }
    }
}
