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
            double x = 1;
            double y = 0;
            double wait = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}