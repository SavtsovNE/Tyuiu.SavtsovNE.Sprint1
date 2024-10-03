using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SavtsovNE.Sprint1.Task4.V13.Lib;

namespace Tyuiu.SavtsovNE.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 5;
            double y = 2;

            DataService dataService = new DataService();

            double result = dataService.Calculate(x, y);

            double expected = 0.002; // Ожидаемый результат, округленный до 3 знаков
            Assert.AreEqual(expected, result, 0.001, "Результат вычисления неверный");
        }
    }
}
