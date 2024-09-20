using Tyuiu.MolodchikovEE.Sprint1.Task0.V2.Lib;

namespace Tyuiu.MolodchikovEE.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);

        }
    }
}