using System;
using System.Collections.Generic;
using System.Text;

using Tyuiu.KorolevSA.Sprint1.Task0.V19.Lib;


// Написать программу, которая вычисляет выражение 4/2*5/(3+2)*5 и печатает результат на экране.

namespace Tyuiu.KorolevSA.Sprint1.Task0.V19
{
    class Calculate
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Королев С.А. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: <Базовые навыки работы в C#>                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Королев Сергей Алексеевич | РППб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая вычисляет 4/2*5/(3+2)*5 и                *");
            Console.WriteLine("* печатает результат на экране.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*4/2*5/(3+2)*5                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}