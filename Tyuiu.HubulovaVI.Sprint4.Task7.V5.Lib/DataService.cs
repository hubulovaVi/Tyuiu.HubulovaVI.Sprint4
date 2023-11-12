using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.HubulovaVI.Sprint4.Task7.V5.Lib
{
    public class DataService 
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mas = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] % 2 == 0) cnt++;
                }
            }
            return cnt;
        }
    }
}