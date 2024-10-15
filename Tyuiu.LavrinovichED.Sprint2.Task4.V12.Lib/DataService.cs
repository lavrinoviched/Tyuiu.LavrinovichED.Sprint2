using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.LavrinovichED.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double a = 2 / (y*y);
            double b = Math.Round(Math.Pow(7 + a, x), 3);
            double c = 3 * x*x - Math.Pow(Math.Cos(y),2) + 10;
            double d = y*y - Math.Sin(x*x) + 12;
            double e = Math.Round ((c / d),3); 

            double z = Math.Sqrt(x) > y * 2 ? b : e; 
            return z; 
        }
    }
}
