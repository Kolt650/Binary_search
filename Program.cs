using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Требуется написать функцию бинарного поиска,
посчитать его асимптотическую сложность 
и проверить работоспособность функции. */

namespace Binary_search
{
    class Program
    {
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        static void Main()
        {
            Test test = new Test();
            Console.WriteLine("Подаётся массив: 1 6 77 123 444 555 660\nИщется число: 88\nОжидается: -1\nРезультат: " + test.DoMass1_ReturnMinusOne());
            Console.WriteLine("\nПодаётся массив: 1 6 77 123 444 555 660\nИщется число: 77\nОжидается: 2\nРезультат: " + test.DoMass1_ReturnTwo());
            Console.WriteLine("\nАссимптотическая сложность алгоритма равна O(N) ");
            Console.ReadKey();
        }
    }
}
