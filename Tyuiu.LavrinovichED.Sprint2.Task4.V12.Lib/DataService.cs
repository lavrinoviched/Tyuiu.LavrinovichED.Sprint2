using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.LavrinovichED.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double a = 2 / Math.Pow (y, 2);
            double b = Math.Pow(7 + a, x) ;
            double c = 3 * Math.Pow(x, 2) - Math.Cos(Math.Pow(y, 2)) + 10;
            double d = Math.Pow(y, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
            double e = c / d; 

            double z = Math.Sin(x) > y * 2 ? b : e; 
            return Math.Round (z, 3); 
        }
    }
}
