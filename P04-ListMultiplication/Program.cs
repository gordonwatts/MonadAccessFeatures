using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_ListMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 0, 1, 2, 3, 10, 20, 30 };

            var l = from l1 in lst
                    select l1 + 1;
            //var l = $(lst + 1);

            // Prints out 1, 2, 3, 4, 11, 21, 31
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
