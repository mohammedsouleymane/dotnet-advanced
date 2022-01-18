using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTest
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void Add9And10()
        {
            var math = new Math();
           
            Assert.AreEqual(19,math.Add(10,9));
        }

        [TestMethod]
        public void Divide10By5()
        {
            var math = new Math();

            Assert.AreEqual(2, math.Divide(10,5));
        }

        [TestMethod]
        public void Divide10By9()
        {
            var math = new Math();

            Assert.AreEqual(1.11, math.Divide(10, 9));
        }

        [TestMethod]
        [DataRow(20)]
        [DataRow(30)]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideByZero(int value)
        {
            var math = new Math();
           Assert.AreEqual(0,math.Divide(value,0));
        }
    }

  
}
