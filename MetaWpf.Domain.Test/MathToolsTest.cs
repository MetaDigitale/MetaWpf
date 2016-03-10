using MetaWpf.Domain.Concretes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetaWpf.Domain.Test
{
    [TestClass]
    public class MathToolsTest
    {
        [TestMethod]
        public void AddTest()
        {
            var mathTools = new MathTools();

            var result = mathTools.Add(10, 10);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void SubstractTest()
        {
            var mathTools = new MathTools();

            var result = mathTools.Substract(10, 9);

            Assert.AreEqual(1, result);
        }
    }
}
