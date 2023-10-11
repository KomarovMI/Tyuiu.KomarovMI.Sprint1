using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMI.Sprint1.Task5.V6.Lib;

namespace Tyuiu.KomarovMI.Sprint1.Task5.V6
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант # 6                                                             *");
            Console.WriteLine("* Выполнил: Комаров Максим Игоревич | ПКТБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  Написать программу которая решает задачу Пусть k – целое от 1 до 365. * ");
            Console.WriteLine("*  Присвоить целой переменной n значение 1,2,...,7 в зависимости от того, *");
            Console.WriteLine("*  на какой день недели (понедельник, вторник,..., воскресенье)           *");
            Console.WriteLine("*  приходится k-й день невисокосного года, в котором 1 января–понедельник *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;
            Console.WriteLine("Введите К от 1 до 365:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(k));
            Console.WriteLine("N="+res);
            Console.ReadKey();

        }
    }
}
