using CommonObjects;
using System;
using System.Linq;
using static CommonObjects.FutureUtils;

namespace P07_FutureReuse
{
    class Program
    {
        static void Main(string[] args)
        {
            IFutureValue<int> v1future = FutureCalculate(10);

            IFutureValue<int> vtotal = from v1 in v1future
                                       select v1 + v1;
            // var vtotal = $(v1future + v1future);

            // Expect this to write out 20!
            Console.WriteLine($"Final value is {vtotal.Value}.");
        }
    }
}
