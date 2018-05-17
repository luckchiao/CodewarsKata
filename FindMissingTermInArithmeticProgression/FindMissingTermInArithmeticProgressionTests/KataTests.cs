using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMissingTermInArithmeticProgression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingTermInArithmeticProgression.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void FindMissingTest_FirstItem()
        {
            var list = new List<int> { 1, 3, 5, 9 };
            var expected = 7;
            var actual = Kata.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindMissingTest_SecondItem()
        {
            var list = new List<int> { 0, 5, 10, 20, 25 };
            var expected = 15;
            var actual = Kata.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindMissingTest_Third()
        {
            var list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            var expected = 10;
            var actual = Kata.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindMissingTest_Fourth()
        {
            var list = new List<int> { 1040, 1220, 1580 };
            var expected = 1400;
            var actual = Kata.FindMissing(list);

            Assert.AreEqual(expected, actual);
        }
    }
}