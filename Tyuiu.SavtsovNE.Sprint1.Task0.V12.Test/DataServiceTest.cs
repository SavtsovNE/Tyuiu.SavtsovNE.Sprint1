using tyuiu.SavtsovNE.Sprint1.Task0.V12.Lib;

namespace tyuiu.SavtsovNE.Sprint1.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            var result = dataService.Calculate();


            //калькулятор
            Assert.AreEqual(6, result);

        }
    }
}