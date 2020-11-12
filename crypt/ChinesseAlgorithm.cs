using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class ChinesseAlgorithm
    {
        public static void count(int size)
        {
            int[] b = new int[size];
            int[] m = new int[size];
            int M = 1;
            bool check = true;

            for(int i = 0; i<size;i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
                m[i] = Convert.ToInt32(Console.ReadLine());
                M *= m[i];
                if (i > 0 && i < size - 1)
                    if (GCD.countGcd(m[i - 1], m[i]) != 1)
                        check = false;
            }
            if(check)
            {
                int[] Mi = new int[size];
                int[] Yi = new int[size];
                int x = 0;
                for (int i =0;i<size;i++)
                {
                    Mi[i] = M / m[i];
                    Yi[i] = reverseElement.calcReverseElem(Mi[i], m[i]);
                    x += b[i] * Mi[i] * Yi[i] % M;
                }
                if(x>M)
                {
                    x = x % M;


                }
                Console.WriteLine($"{x} +{ M}t");

            }
            else
            {
                Console.WriteLine("Null");
            }
        }
    }
}
