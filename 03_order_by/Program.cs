﻿using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace _03_order_by
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 5, 34, 67, -12, 94, -42 };

            IEnumerable<int> query = from i in arrayInt
                                     where i % 2 == 0
                                     orderby Math.Abs(i) ascending //(default) //descending
                                     select i;

            WriteLine("Even elements ascending:");
            foreach (int item in query)
            {
                Write($"{item}\t");
            }
            WriteLine();

            // Метод розширення
            var result = arrayInt.Where(i => i % 2 == 0).OrderByDescending(i => Math.Abs(i));

            WriteLine("Even elements descending:");
            foreach (int item in result)
            {
                Write($"{item}\t");
            }
            WriteLine();           
        }
    }
}
