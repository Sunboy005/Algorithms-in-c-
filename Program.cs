using System;
using System.Linq;

namespace CSharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            int[] newArr = new int[] { 2, 3, 4, 5 };
            foreach (int num in newArr)
            {
                Console.WriteLine(num);//Outputting each member of an Array
            }
            Console.WriteLine("##################");//Spacing Each Solution

            Console.WriteLine("Assigning variable a,b,c to 246 resp n o");
            int a = 2;
            int b = 4;
            int c = 6;
            int[] arrNew = new int[] { a, b, c };
            foreach (int num in arrNew)
            {
                Console.WriteLine(num);//Outputting each member of an Array
            }

            Console.WriteLine("##################");//Spacing Each Solution

            Console.WriteLine("Using Linq ");

            int[] numberArr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine($"The maximum number using Num.max() is {numberArr.Max()}");//
            Console.WriteLine($"The maximum number using Num.max() is {numberArr.Min()}");//
            Console.WriteLine($"The maximum number using Num.max() is {numberArr.Reverse()}");//
            Console.WriteLine($"The maximum number using Num.max() is {numberArr.Sum()}");//
            Console.WriteLine($"The maximum number using Num.max() is {numberArr.Average()}");//

            Console.WriteLine("##################");//Spacing Each Solution

            Console.WriteLine("");
        }
    }
}
