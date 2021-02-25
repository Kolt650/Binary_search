using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    public class Test
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

        //подаётся массив 1 6 77 123 444 555 660
        //ищется число 88
        //ожидается -1
        public int DoMass1_ReturnMinusOne()
        {
            int[] intArray = new int[] { 1, 6, 77, 123, 444, 555, 660 };
            return BinarySearch(intArray, 88);
        }

        //подаётся массив 1 6 77 123 444 555 660
        //ищется число 77
        //ожидается 2
        public int DoMass1_ReturnTwo()
        {
            int[] intArray = new int[] { 1, 6, 77, 123, 444, 555, 660 };
            return BinarySearch(intArray, 77);
        }
        //
    }
}

