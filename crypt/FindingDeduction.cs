using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class FindingDeduction
    {
        static public int countDeduction(int a, int k, int m)
        {
            if(trial_div(m))
            {
                    if(GCD.countGcd(a,m) == 1)
                    {
                        Console.WriteLine($"{a}^{k}(mod{m})={a}^{k%(m-1)}(mod{m}){BigInteger.ModPow(a,k%(m-1),m)}"); // a^k(mod m ) = a ^ k%(m-1) (mod m ) = modpow(a,k%(m-1),m);
                    }
                    else
                    {
                        Console.WriteLine($"{a} and {m} not simple");//
                    }
                
            }
            else
            {
                Console.WriteLine("m - composite");
                Dictionary<int, int> mp = new Dictionary<int, int>();
                mp = primeFactorization.count(m); //primeFactorization
                List<int> b = new List<int>();
                List<int> mi = new List<int>();
                foreach (var item in mp)
                {
                    mi.Add(item.Key);
                    b.Add((int)Math.Pow(a, k % (item.Key-1)));
                }
                int x = ChinesseAlgorithm.count(b, mi);
                if(x!=-1)
                {
                    Console.WriteLine($"{a}^{k}(mod{m})= {x}");
                }
            }
            return 0;
        }

        static public bool trial_div(int n)
        {
            int r = 2;
            while(r<Math.Sqrt(n))
            {
                if (n % r == 0)
                {
                    return false;
                }
                else r++;
            }
            return true;
        }

    }
}
