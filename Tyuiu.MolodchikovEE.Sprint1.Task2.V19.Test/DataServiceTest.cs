using Tyuiu.MolodchikovEE.Sprint1.Task2.V19.Lib;


namespace Tyuiu.MolodchikovEE.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(0, res);
        }
    }
}