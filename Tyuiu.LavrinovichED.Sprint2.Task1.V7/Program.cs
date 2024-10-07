//a = 195, b = 16, c = 14, d = 45

using Tyuiu.LavrinovichED.Sprint2.Task1.V7.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d); 

            Console.Title = "Спринт #1 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                       *");
            Console.WriteLine("* Тема: Логические операции                                                       *");
            Console.WriteLine("* Задание #1                                                                      *");
            Console.WriteLine("* Вариант #7                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                 *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)      *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не       *");
            Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет            *");
            Console.WriteLine("* логическую последовательность(массив): (True, False, False, False, True, False) *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine(" a = " + a); 
            Console.WriteLine(" b = " + b); 
            Console.WriteLine(" c = " + c); 
            Console.WriteLine(" d = " + d);

            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                       *");
            Console.WriteLine("***********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]); 
            }
        }
    }
}
