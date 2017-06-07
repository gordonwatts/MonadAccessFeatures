using CommonObjects;
using System;
using System.Linq;
using static CommonObjects.FutureUtils;

namespace P02_TheIdealSituation
{
    class Program
    {
        static void Main(string[] args)
        {
            IFutureValue<int> v1future = FutureCalculate(10);
            IFutureValue<int> v2future = FutureCalculate(5);

            IFutureValue<int> vtotal = $(v1future + v2future);

            // Expect this to write out 15!
            Console.WriteLine($"Final value is {vtotal.Value}.");
        }
    }
}
