﻿using Algorithms.Arrays;
using Algorithms.Heaps;
using Algorithms.Sortings;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new KIncreaseDecreaseArray();

            algorithm.ReadInput();
            algorithm.Execute();
        }
    }
}
