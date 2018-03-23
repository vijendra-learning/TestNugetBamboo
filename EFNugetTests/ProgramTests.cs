using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFNuget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNuget.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void AddNumbersTest()
        {
            Program myPrg = new Program();
            var result = myPrg.AddNumbers(10, 20);
            Assert.AreEqual(result, 30);
        }
    }
}