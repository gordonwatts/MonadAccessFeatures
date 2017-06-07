using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_ListResue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 0, 1, 2, 3 };

            var l = from l1 in lst
                    select l1 + l1;
            // var l = $(lst + lst);

            // Output 0, 2, 4, 6
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
