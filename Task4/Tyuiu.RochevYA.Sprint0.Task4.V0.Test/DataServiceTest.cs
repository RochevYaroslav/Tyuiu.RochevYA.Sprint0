using Tyuiu.RochevYA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.RochevYA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(10, DataService.Substraction(15, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(25, DataService.Multiplication(5, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(5, DataService.Division(25, 5));
        }
    }
}