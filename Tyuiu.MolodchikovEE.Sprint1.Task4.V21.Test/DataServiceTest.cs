using Tyuiu.MolodchikovEE.Sprint1.Task4.V21.Lib;


namespace Tyuiu.MolodchikovEE.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 60;
            double y = 30;
            double wait = 41.011;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}