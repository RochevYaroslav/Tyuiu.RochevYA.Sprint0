using Tyuiu.RochevYA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.RochevYA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Yarik";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello, Yarik", res);
        }
    }
}
