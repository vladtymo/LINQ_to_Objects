using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_anonymous_method
{
    class Program
    {
        //static bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            //Func<int, bool> isEvenDelegate = IsEven;

            //Func<int, bool> isEvenDelegate = (item) => item % 2 == 0;

            //Func<int, int> changeDelegate = (i) => i + 1;

            var result = numbers.Where(item => item % 2 == 0).Select(i => i + 1);

            foreach (int i in result)
                Console.WriteLine(i);
        }
    }
}
