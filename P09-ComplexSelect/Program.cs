using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_ComplexSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = { 0, 1, 2, 3 };

            var l = from l1 in lst
                    select { var tmp = l1; return tmp; }; // Fortunately, this is illegal - imagine putting this into $( and )?
        }
    }
}
