using tyuiu.SavtsovNE.Sprint1.Task1.V22.Lib;

namespace tyuiu.SavtsovNE.Sprint1.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(3, res); // Åñëè 3 — ýòî ïðàâèëüíûé ðåçóëüòàò


        }
    }

}