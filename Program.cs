﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Immutable;

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

            Console.WriteLine("Using Linq given: [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 ]");

            int[] numberArr = new int[] { 9, 6, 5, 1, 2, 7, 4, 8, 3, 0 };
            Console.WriteLine($"The maximum number using Num.Max() is {numberArr.Max()}");//
            Console.WriteLine($"The Minimum number using Num.Min() is {numberArr.Min()}");//
            //Console.WriteLine($"The maximum number using Num.max() is {numberArr.Reverse()}");//
            Console.WriteLine($"The maximum number using Num.Sum() is {numberArr.Sum()}");//
            Console.WriteLine($"The maximum number using Num.Average() is {numberArr.Average()}");//

            Console.WriteLine("##################");//Spacing Each Solution
            Console.WriteLine("Sorting an Array requires outputting an array");//Spacing Each Solution
            Array.Sort(numberArr);
            foreach (var sorted in numberArr)
                Console.WriteLine(sorted);

            Console.WriteLine("Reversing an Array requires outputting an array");//Spacing Each Solution
            Array.Reverse(numberArr);
            foreach (var reversed in numberArr)
            {
                Console.Write(reversed);
            }
            Console.WriteLine("");
            //string str = "Hello";
            //char[] chars = str.ToCharArray();
            char[] chars = { 't', 'i', 'm', 'e' };
            Array.Reverse(chars);
            foreach (char chara in chars)
            {
                Console.Write(chara);
            }
            Console.WriteLine("");
            IQueryable<char> answ = chars.AsQueryable().Reverse();
            foreach (char str in answ)
            {
                Console.Write(str);
            }
            string herm = "Hello";
            string[] grease = herm.Split();
            foreach (string chara in grease) {
                Console.WriteLine(chara);
            }

            List<int> points = new List<int> { 5, 10, 5, 20, 30, 30, 40, 50, 60, 70 };
            IEnumerable<int> res=points.AsQueryable().Distinct();
            foreach(int nexted in res)
            {
                Console.WriteLine(nexted);
            }


            //IQueryable<char> res = chars.AsQueryable().Reverse();
            //Console.Write("\nReversed String = ");
            //foreach (char chara in res)
            //{
            //    Console.Write(chara);
            //}
            //Console.WriteLine($"The maximum number using Num.max() is {Array.Reverse(numberArr)}");//
            //Console.WriteLine($"The maximum number using Num.max() is {Array.Reverse()}");//
            //Console.WriteLine($"The maximum number using Num.max() is {numberArr.Sum()}");//
            //Console.WriteLine($"The maximum number using Num.max() is {numberArr.Average()}");//

            Console.WriteLine("");
        }
    }
}
