using Tyuiu.SavtsovNE.Sprint1.Task7.V19.Lib;
namespace Tyuiu.SavtsovNE.Sprint1.Task7.V19.Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1()
        {
            double x = 2;

            DataService ds = new DataService();
            double res = ds.Calculate(x);
            double wait = 15.409;
            Assert.AreEqual(wait, res);
        }
    }
}