using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaEgory
{
    class Program
    {
        static int min_of_positive(int[] arr)
        {
            int result = arr[0];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > 0)
                {
                    if(arr[i] < result)
                    {
                        result = arr[i];
                    }
                }
            }
            return result;
        }
        static int max_of_negative(int[]arr)
        {
            int result = arr[0];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    if (arr[i] < result)
                    {
                        result = arr[i];
                    }
                }
            }
            return result;
        }
        static int f3(int [] arr)
        {
            int result = 0;
            for(int i = 0; i<arr.Length; ++i)
            {
                if(arr[i] > 0 )
                {
                    result += arr[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 70, 6, 7, 8, 9, 10 };
            Console.WriteLine(min_of_positive(arr));
            int[] arr1 = new int[10] { -1,-2,-3,-7,-8,-30,-100,-80,-6,-13 };
            Console.WriteLine(max_of_negative(arr1));
            int[] arr2 = new int[5] { -1, 1,2,3,4};
            Console.WriteLine(f3(arr2));
            Console.Read();
        }
    }
}
