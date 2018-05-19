using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void ReverseWords_First_Test()
        {
            var actual = Kata.ReverseWords("This is an example!");
            Assert.AreEqual("sihT si na !elpmaxe", actual);
        }

        [TestMethod()]
        public void ReverseWords_Second_Test()
        {
            var actual = Kata.ReverseWords("double  spaces");
            Assert.AreEqual("elbuod  secaps", actual);
        }
    }
}