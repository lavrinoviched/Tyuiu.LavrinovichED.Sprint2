using Tyuiu.LavrinovichED.Sprint2.Task5.V11.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                   *");
            Console.WriteLine("* Тема: Оператор switch                                                                       *");
            Console.WriteLine("* Задание #5                                                                                  *");
            Console.WriteLine("* Вариант #11                                                                                 *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                  *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет требуемое значение        *");
            Console.WriteLine("* и возвращает результат                                                                      *");
            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine("Введите год"); 
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца");
            int m=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            if (((n < 1) && (n > 31)) || ((m < 1) && (m > 12)))
            {
                Console.WriteLine("Введены неправильные данные");
            }
                else
                {
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                    Console.WriteLine("***************************************************************************");
                Console.WriteLine("На следующий день будет " + ds.FindDateOfNextDay(g, m, n));

                }
            
            Console.ReadKey();
        }
    }
}
