using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandlingMixer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingMixer.Tests
{
    [TestClass()]
    public class MathUtilsTests
    {
        [TestMethod()]
        public void LerpTest()
        {
            Assert.AreEqual(MathUtils.Lerp(0f, 1f, 0.5f), 0.5f);
            Assert.AreEqual(MathUtils.Lerp(1f, 0f, 0.5f), 0.5f);
        }
    }
}