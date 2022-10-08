﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TwoNumsStingReturnsSum()
        {
            Assert.AreEqual(7, obj.add("3,4"));
        }

        [TestMethod]
        public void MultipleNumsStingReturnsSum()
        {
            Assert.AreEqual(10, obj.add("3,4,3"));
        }

        [TestMethod]
        public void NewlinesBetweenNumsStingReturnsSum()
        {
            Assert.AreEqual(8, obj.add("3\n2,3"));
        }

        //Test Support different delimiters
        [TestMethod]
        public void MaltipleDelimitersBetweenNumsReturnsSum()
        {
            Assert.AreEqual(3, obj.add("//;\n1;2"));
        }
    }
}
