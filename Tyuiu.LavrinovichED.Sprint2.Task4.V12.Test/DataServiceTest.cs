using Tyuiu.LavrinovichED.Sprint2.Task4.V12.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidContinion1()
        {
            DataService ds = new DataService();
            double x = 25;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 7.525;
            Assert.AreEqual(res, wait); 
        }

        [TestMethod]
        public void ValidContinion2() 
        {
            DataService ds = new DataService(); 
            double x = 4; 
            double y = 2; 
            double res = ds.Calculate(x, y);
            double wait = 3.601;
            Assert.AreEqual(res, wait); 
        }
    }
}