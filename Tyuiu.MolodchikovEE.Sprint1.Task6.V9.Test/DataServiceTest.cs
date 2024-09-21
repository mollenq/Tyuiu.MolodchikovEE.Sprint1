using Tyuiu.MolodchikovEE.Sprint1.Task6.V9.Lib;


namespace Tyuiu.MolodchikovEE.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string strTest = "Hello World";
            string wait = "oHell dWorl";
            string res = ds.MoveLetterToStart(strTest);
            Assert.AreEqual(wait,res);
        }
    }
}