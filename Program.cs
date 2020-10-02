using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Computer_Science
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = {1,2,3,4,5,6,7,8,9,10};
            int[,] myMatrix1 =
            {
                {1,2},
                {3,1}
            };
            int[,] myMatrix2 =
            {
                {1,2,3},
                {16,17,3},
            };
            
            Reverse(myArr);
            MultiplyMatrix(myMatrix1, myMatrix2);
        }

        static void Reverse(int[] arr)
        {
            Display(arr);
            Display(arr);
        }

        static void Display(int[] myArr)
        {
            foreach (var i in myArr)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(myArr);
        }

        static void MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[] myarr = new int[6];
        }
    }
}
