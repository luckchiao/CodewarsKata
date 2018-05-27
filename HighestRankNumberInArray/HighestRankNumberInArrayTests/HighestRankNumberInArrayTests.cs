using Microsoft.VisualStudio.TestTools.UnitTesting;
using HighestRankNumberInArray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestRankNumberInArray.Tests
{
    [TestClass()]
    public class HighestRankNumberInArrayTests
    {
        [TestMethod()]
        public void HighestRank_First_Case_Test()
        {
            var actual = HighestRankNumberInArray.HighestRank(new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 });
            Assert.AreEqual(3, actual);
        }

        [TestMethod()]
        public void HighestRank_Second_Case_Test()
        {
            var actual = HighestRankNumberInArray.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 });
            Assert.AreEqual(12, actual);
        }
    }
}