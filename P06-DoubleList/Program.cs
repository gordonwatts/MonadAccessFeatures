using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_DoubleList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst1 = { 0, 1, 2 };
            int[] lst2 = { 10, 20, 30 };

            var l = from l1 in lst1
                    from l2 in lst2
                    select l1 + l2;
            //var l = $(lst1 + lst2);

            // Writes out 10, 20, 30, 11, 21, 31, 12, 22, 32
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
