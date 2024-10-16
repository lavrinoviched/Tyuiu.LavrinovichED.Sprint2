using Tyuiu.LavrinovichED.Sprint2.Task5.V11.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            int g = 2024;
            int m = 11;
            int n = 13;

            Assert.AreEqual("14.11.2024", ds.FindDateOfNextDay(g, m, n));


            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2024, 11, 13);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(2006, 12, 30);
            });
        }
    }
}