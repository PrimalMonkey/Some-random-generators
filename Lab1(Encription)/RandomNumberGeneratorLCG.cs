using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Encription_
{
    class RandomNumberGeneratorLCG
    {
        private const long m = 4294967296; // aka 2^32
        private const long a = 1664525;
        private const long c = 1013904223;
        private long last;

        public RandomNumberGeneratorLCG()
        {
            last = 3;
        }

        public RandomNumberGeneratorLCG(long seed)
        {
            last = seed;
        }

        public long Next()
        {
            last = ((a * last) + c) % m;

            return last;
        }

        public long Next(long maxValue)
        {
            return Next() % maxValue;
        }
    }
}
