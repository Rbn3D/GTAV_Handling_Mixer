using Microsoft.VisualStudio.TestTools.UnitTesting;
using HandlingMixer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using SimpleExpressionEvaluator;

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

    [TestClass()]
    public class MathEvaluationTests
    {
        [TestMethod()]
        public void DontUseAllProvidedVariablesShouldWorkTest()
        {
            dynamic ev = new ExpressionEvaluator(CultureInfo.InvariantCulture);

            Decimal x = 5;
            float a = 6f;
            float b = 7f;

            // Don't using "x" variable
            var exp = "(a + b) / 2";

            var test = ev.Evaluate(exp, x: x, a: a, b: b);
            var i = test;
        }
    }
}