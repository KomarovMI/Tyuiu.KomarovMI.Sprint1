using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMI.Sprint1.Task7.V28.Lib;

namespace Tyuiu.KomarovMI.Sprint1.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Комаров М.И. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант # 28                                                            *");
            Console.WriteLine("* Выполнил: Комаров Максим Игоревич | ПКТБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Написать программу, которая вычисляет математическое выражение .      * ");
            Console.WriteLine("*  по исходным значениям данных, вводимых пользователем.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*             2        1       2                                           *");
            Console.WriteLine("*       Z=cos   = sin(--- )+ y                                             *");
            Console.WriteLine("*                      x                                                   *");

            double x, y;
            Console.WriteLine("Введите Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Z=" + ds.Calculate(x, y));
            Console.ReadKey();



        }
    }
}
