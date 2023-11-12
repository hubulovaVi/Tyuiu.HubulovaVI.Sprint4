using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.HubulovaVI.Sprint4.Task7.V5.Lib;

namespace Tyuiu.HubulovaVI.Sprint4.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Хубулова В. И. | АСОИУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Хубулова Валерия Игоревна | АСОИУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '246813579''.                         *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            int[,] mas = new int[n, m];
            string str = "246813579";
            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");


            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);
            Console.WriteLine("Количество четных элементов: " + res);

            Console.ReadKey();
        }
    }
}