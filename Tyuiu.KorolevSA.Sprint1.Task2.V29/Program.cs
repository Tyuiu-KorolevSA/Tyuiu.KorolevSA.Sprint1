using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Tyuiu.KorolevSA.Sprint1.Task2.V29.Lib;

namespace Tyuiu.KorolevSA.Sprint1.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Королев С.А. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: <Базовые навыки работы в C#>                                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Королев Сергей Алексеевич | РППб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать, котораз запрашивает у пользователя исходные данные, вычисляет *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int timeSec;

            Console.WriteLine("Введите количество секунд:");
            timeSec = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество целых минут:" + dataService.Calculate(timeSec));
        }
    }
}
