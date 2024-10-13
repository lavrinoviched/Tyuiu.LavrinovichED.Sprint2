using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.LavrinovichED.Sprint2.Task2.V12.Lib;

public class DataService : ISprint2Task2V12
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        bool a = true;

        if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 12))
        {
            if ((x == 3) && (y >= 3) && (y <= 7) || (y == 11))
            {
                return a = true;
            }
            if ((x == 4) && (y >= 3) && (y <= 7) || (y == 11))
            {
                return a = true;
            }
            if ((x == 5) && (y >= 3) && (y <= 7) || (y == 11))
            {
                return a = true;
            }
            if ((x == 6) && (y >= 5) && (y <= 11))
            {
                return a = true;
            }
            if ((x == 7) && (y >= 5) && (y <= 12))
            {
                return a = true;
            }
            if ((x >= 8) && (x <= 5) && (y >= 8))
            {
                return a = true;
            }
            if ((x >= 9) && (x <= 10) && (y >= 3) && (y <= 8))
            {
                return a = true;
            }
            if ((x >= 11) && (x <= 12) && (y >= 3) && (y <= 12))
            {
                return a = true;
            }
            if ((x == 13) && (y <= 6) && (y >= 8))
            {
                return a = true;
            }

            return a;
        }
        else
        {
            return false;
        }

    }

}