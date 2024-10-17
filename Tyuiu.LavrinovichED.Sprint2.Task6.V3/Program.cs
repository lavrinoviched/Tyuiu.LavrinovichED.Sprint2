using Tyuiu.LavrinovichED.Sprint2.Task6.V3.Lib; 

namespace Tyuiu.LavrinovichED.Sprint2.Task6.V3
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
            Console.WriteLine("* Задание #6                                                                                  *");
            Console.WriteLine("* Вариант #3                                                                                  *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                  *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
            Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет требуемое значение        *");
            Console.WriteLine("* и возвращает результат                                                                      *");
            Console.WriteLine("*                                                                                             *");
            Console.WriteLine("***********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine("Введите порядковый номер дня недели");
            int value = Convert.ToInt32(Console.ReadLine()); 

            if ((value < 1) && (value >7))
            {
                Console.WriteLine("Введены неверные данные");
            }
            else
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("День недели: " + ds.FindDayName(value));
            }

            Console.ReadKey();

        }
    }
}
