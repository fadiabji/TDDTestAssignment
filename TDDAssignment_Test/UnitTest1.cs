using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDAssignment;

namespace TDDAssignment_Test
{
    [TestClass]
    public class UnitTest1
    {

        KataCalculator obj = new KataCalculator();

        [TestMethod]
        public void EmptyStingReturnsZero()
        {
            Assert.AreEqual(0, obj.add(""));
        }

        [TestMethod]
        public void OneNumStingReturnsNumItself()
        {
            Assert.AreEqual(1, obj.add("1"));
        }

        [TestMethod]
        public void TwoNumStingReturnsSum()
        {
            Assert.AreEqual(7, obj.add("3,4"));
        }
    }
}
