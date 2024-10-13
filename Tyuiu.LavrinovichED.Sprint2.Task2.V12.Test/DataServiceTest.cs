using Tyuiu.LavrinovichED.Sprint2.Task2.V12.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task2.V12.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int x = 8;
        int y = 9;

        bool res = ds.CheckDotInShadedArea(x, y);
        bool wait = true;

        Assert.AreEqual(wait, res);
    }
}