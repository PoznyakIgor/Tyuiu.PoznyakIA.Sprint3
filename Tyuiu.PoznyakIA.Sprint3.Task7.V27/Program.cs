using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint3.Task7.V27.Lib;

namespace Tyuiu.PoznyakIA.Sprint3.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Позняк И.А | ИСТНб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Позняк И.А | ИСТНб-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + endValue);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] array = ds.GetMassFunction(startValue, endValue);

            Console.WriteLine("+------------+------------+");
            Console.WriteLine("|      X     |    f(x)    |");
            Console.WriteLine("+------------+------------+");

            foreach (double i in array)
            {
                Console.WriteLine("|{0,7:d}     |  {1, 7:f2}   |", startValue++, i);
            }

            Console.WriteLine("+------------+------------+");
            Console.ReadKey();
        }
    }
}
