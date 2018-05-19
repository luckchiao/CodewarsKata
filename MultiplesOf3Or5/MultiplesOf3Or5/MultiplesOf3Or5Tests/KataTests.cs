using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplesOf3Or5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3Or5.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void MultiplesOf3Or5_Below_10_Test()
        {
            var actual = Kata.MultiplesOf3Or5(10);
            Assert.AreEqual(23, actual);
        }

        [TestMethod()]
        public void MultiplesOf3Or5_Below_5_Test()
        {
            var actual = Kata.MultiplesOf3Or5(5);
            Assert.AreEqual(3, actual);
        }

        [TestMethod()]
        public void MultiplesOf3Or5_Below_18_Test()
        {
            var actual = Kata.MultiplesOf3Or5(18);
            Assert.AreEqual(60, actual);
        }
    }
}