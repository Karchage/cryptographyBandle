using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class primeFactorization
    {
        static public Dictionary<int,int> count(int num)
        {
            int div = 2;
            Console.Write($"{num} = ");
            Dictionary<int, int> mp = new Dictionary<int, int>();
            while (num > 1)
            {
                int i = 0;
                while(num % div == 0)
                {
                    i++;
                    num = num / div;
                }
                if(i!=0)
                {
                    mp.Add(div, i);
                    //Console.Write("*" + div + "^" + i);
                }
                div++;
            }
            foreach(var item in mp)
            {
                Console.Write($"{item.Key}^{item.Value}");
                if(item.Key != mp.Keys.Last())
                {
                    Console.Write(" * ");
                }
            }
            return mp;
        }
    }
}
