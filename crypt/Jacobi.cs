using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class Jacobi
    {
        public static int calcJacobi(int a, int n)
        {
            a = a % n;
            int t = 1;
            while( a != 0)
            {
                while(a % 2 == 0)
                {
                    a = a / 2;
                    int r = n % 8;
                    if(r == 3 || r == 5)
                    {
                        t = -t;
                    }
                }
                int temp = a;
                a = n;
                n = temp;
                if (a % 4 == 3 && n % 4 == 3)
                {
                    t = -t;
                }
                a = a % n;
            }
            if(n == 1)
            {
                return t;
            }
            else
            {
                return 10000;
            }
        }
    }
}
