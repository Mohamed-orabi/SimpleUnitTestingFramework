using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnitTesting
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void AdditionTest()
        {
            int result = 2 + 3 + 6;
            if (result != 5)
            {
                throw new Exception("AdditionTest failed!");
            }
        }

        [TestMethod]
        public void SubtractionTest()
        {
            int result = 5 - 3;
            if (result != 2)
            {
                throw new Exception("SubtractionTest failed!");
            }
        }

        [TestMethod]
        public void AdditionTestWithAssert()
        {
            int result = 2 + 3;
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SubtractionTestWithAssert()
        {
            int result = 5 - 3;
            Assert.AreEqual(2, result);
        }
    }
}
