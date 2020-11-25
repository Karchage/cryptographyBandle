using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class AntiderivativeRoot
    {
        public static void countRoot(int m)
        {
            int phi = EulerFunction.calcEulerFunction(m);
            Dictionary<int, int> fact = primeFactorization.count(phi);
            int count = 0;
            foreach(var item in fact)
            {
                if(GCD.countGcd(item.Key,m)==1)
                {
                    bool check = true;
                    foreach(var itemNext in fact)
                    {
                        if(BigInteger.ModPow(item.Key,itemNext.Key,m)==1)
                        {
                            check = false;
                        }
                    }
                    if(check)
                    {
                        count++;
                        Console.WriteLine();
                        Console.WriteLine($"{item.Key} - Antiderivative root");
                        Console.Write($"U({m})= " + "{");
                        for (var i = 0; i < phi; i++)
                        {
                            Console.Write($" {BigInteger.ModPow(item.Key, i, m)} ");
                        }
                        Console.WriteLine("}");
                    }
                }
            }
            if(count ==0)
            {
                Console.WriteLine(" - Not antiderivative root");
            }
        }

    }
}
