using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class LinearConGenerator
    {
        static int _seed = (int)DateTime.Now.Ticks; // from bad random gens might as well have bad seed!
        static int _bsdCurrent = _seed;
        static int Next(int seed, int a, int b) => (a * seed + b) & int.MaxValue;
        static int Randomise() => _bsdCurrent = Next(_bsdCurrent, 1103515245, 12345);
        static public void PrintRandom(int count)
        {
            Console.WriteLine($"{count} Random");
            var gen = (Func<int>)(Randomise);
            foreach (var r in Enumerable.Repeat(gen, count))
            {
                Console.WriteLine(r.Invoke());
            }
        }
    }
}
