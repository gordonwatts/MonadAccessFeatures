using CommonObjects;
using System;
using System.Linq;
using static CommonObjects.FutureUtils;

namespace P01_WhatWeWillReplace
{
    class Program
    {
        /// <summary>
        /// Demo of what the code looks like to calculate two items
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IFutureValue<int> v1future = FutureCalculate(10);
            IFutureValue<int> v2future = FutureCalculate(5);

            IFutureValue<int> vtotal = from v1 in v1future
                                      from v2 in v2future
                                      select v1 + v2;

            // Expect this to write out 15!
            Console.WriteLine($"Final value is {vtotal.Value}.");
        }
    }
}
