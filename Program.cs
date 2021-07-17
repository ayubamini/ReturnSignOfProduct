using System;

namespace ReturnSignOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[4] { 1, -2, -3, 5 };  // 1
            //var arr = new int[4] { 1, 2, 3, -5 };  // -1
            //var arr = new int[4] { 1, 2, 0, 5 };  // 0

            Console.WriteLine(Solution(arr));
        }

        static int Solution(int[] a)
        {
            var result = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                result *= a[i];
            }

            if (result > 0)
                return 1;

            else if (result < 0)
                return -1;

            else 
                return 0;
        }
    }
}
