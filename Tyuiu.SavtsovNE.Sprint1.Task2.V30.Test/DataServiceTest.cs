using tyuiu.SavtsovNE.Sprint1.Task2.V30.Lib;

namespace tyuiu.SavtsovNE.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(1000, dataService.ConvertKmToMetre(1));

        }
    }
}