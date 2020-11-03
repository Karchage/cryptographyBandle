using System;

namespace crypt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GCD.countGcd(5, 15));
            Console.WriteLine(decompositionGCD.countDegGCD(1234, 54));
            primeNumber.search(225);
            primeFactorization.count(1155);
        }
    }
}
