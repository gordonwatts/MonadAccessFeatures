using CommonObjects;
using System;
using System.Linq;
using static CommonObjects.FutureUtils;

namespace P05_AddANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            IFutureValue<int> v1future = FutureCalculate(10);

            IFutureValue<int> vtotal = from v1 in v1future
                                       select v1 + 1;
            //IFutureValue<int> vtotal = $(v1future + 1);

            // Expect this to write out 11!
            Console.WriteLine($"Final value is {vtotal.Value}.");
        }
    }
}
