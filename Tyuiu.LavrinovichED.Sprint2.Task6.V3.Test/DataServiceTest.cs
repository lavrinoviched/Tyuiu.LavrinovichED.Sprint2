using Tyuiu.LavrinovichED.Sprint2.Task6.V3.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("�����������", ds.FindDayName(1));
            Assert.AreEqual("�������", ds.FindDayName(2));
            Assert.AreEqual("�����", ds.FindDayName(3));
            Assert.AreEqual("�������", ds.FindDayName(4));
            Assert.AreEqual("�������", ds.FindDayName(5));
            Assert.AreEqual("�������", ds.FindDayName(6));
            Assert.AreEqual("�����������", ds.FindDayName(7));

            Assert.ThrowsException<ArgumentException>(() =>
            {  ds.FindDayName(8); }); 

            Assert.ThrowsException<ArgumentException>(() => 
            { ds.FindDayName(-1); }); 
        

        }
    }
}