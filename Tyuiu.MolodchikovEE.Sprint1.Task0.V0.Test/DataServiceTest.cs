using Tyuiu.MolodchikovEE.Sprint1.Task0.V2.Lib;


namespace Tyuiu.MolodchikovEE.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataServiceTest dc = new DataServiceTest();
            var res = dc.Calculate();
            Assert.AreEqual(2, res);

        }
    }
}