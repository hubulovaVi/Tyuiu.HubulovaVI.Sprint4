using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.HubulovaVI.Sprint4.Task2.V14.Lib;

namespace Tyuiu.HubulovaVI.Sprint4.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Хубулова В. И. | АСОИУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнила: Хубулова Валерия Игоревна| АСОИУб-23-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8 подсчитать                *");
            Console.WriteLine("* сумму нечетных элементов массива.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Random rnd = new Random();

            int len;


            Console.Write("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numArry = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numArry[i] = rnd.Next(1, 9);
            }

            Console.WriteLine();
            Console.Write("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numArry[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Произведение всех нечётных элементов массива:" + ds.Calculate(numArry));

            Console.ReadKey();
        }
    }
}