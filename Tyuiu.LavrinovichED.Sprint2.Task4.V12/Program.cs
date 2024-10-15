using Tyuiu.LavrinovichED.Sprint2.Task4.V12.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task4.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                   *");
            Console.WriteLine("* Тема: Тернарный оператор                                                                    *");
            Console.WriteLine("* Задание #4                                                                                  *");
            Console.WriteLine("* Вариант #12                                                                                 *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                  *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции с использованием           *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменной Х, Y с клавиатуры         *");
            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine(" Введите значение X = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Введите значение Y = ");
            double y = Convert.ToDouble(Console.ReadLine()); 

            double res =  ds.Calculate(x, y);

            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                                   *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine(" Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
