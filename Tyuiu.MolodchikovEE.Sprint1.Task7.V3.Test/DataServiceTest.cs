using Tyuiu.MolodchikovEE.Sprint1.Task7.V3.Lib;


namespace Tyuiu.MolodchikovEE.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double wait = 92183.468;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}