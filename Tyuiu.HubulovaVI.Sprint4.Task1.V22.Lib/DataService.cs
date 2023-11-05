using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.HubulovaVI.Sprint4.Task1.V22.Lib
{
    public class DataService : ISprint4Task1V22
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > 10)
                {
                    sumArray += array[i];

                }
            }
            return sumArray;
        }
    }
}