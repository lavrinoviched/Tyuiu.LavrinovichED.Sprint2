﻿using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.LavrinovichED.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y; 
            res[1] = x-70 != y; 
            res[2] = x < y; 
            res[3] = x - 50 > y; 
            res[4] = x - 70  <= y; 
            res[5] = x >= y;

            return res; 
        }
    }
}
