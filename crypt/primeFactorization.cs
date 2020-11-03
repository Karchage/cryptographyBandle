using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class primeFactorization
    {
        static public void count(int num)
        {
            int div = 2, i = 0;
            Console.WriteLine(" ");
            Console.Write("1");
            while (num > 1)
            {
                while(num % div == 0)
                {
                    i++;
                    num = num / div;
                }
                if(i>0)
                {
                    Console.Write("*" + div + "^" + i);
                    i = 0;
                }
                div++;
            }
        }
    }
}
