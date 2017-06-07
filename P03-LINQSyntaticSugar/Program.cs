using CommonObjects;
using System;
using System.Linq;
using static CommonObjects.FutureUtils;

namespace P03_LINQSyntaticSugar
{
    class Program
    {
        /// <summary>
        /// Show how the LINQ from statement in P01 is syntatic sugar already
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IFutureValue<int> v1future = FutureCalculate(10);
            IFutureValue<int> v2future = FutureCalculate(5);

            IFutureValue<int> vtotal = v1future
                .SelectMany(v1 => v2future, (u,v) => u+v);

            // Expect this to write out 15!
            Console.WriteLine($"Final value is {vtotal.Value}.");
        }
    }
}
