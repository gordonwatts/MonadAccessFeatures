using CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CommonObjects.FutureUtils;

namespace P10_FunctionCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            IFutureValue<int> v1future = FutureCalculate(10);

            IFutureValue<int> vtotal = from v1 in v1future
                                       select Calc(v1);
            //IFutureValue<int> vtotal = $(Calc(v1future));

            // Writes out "Calc(int)" "10"
            Console.WriteLine($"Final value is {vtotal.Value}.");
        }

        private static int Calc (int f)
        {
            Console.WriteLine("Calc(int)");
            return f * 2;
        }

        private static IFutureValue<int> Calc(IFutureValue<int> f)
        {
            Console.WriteLine("Calc(IFutureValue<int>)");
            return f;
        }
    }
}
