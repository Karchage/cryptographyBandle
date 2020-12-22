using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class Comparison
    {
        public void PowerComparison(int a, int n, int? b, int p)
        {
            Console.WriteLine($"{a}X^{n}={b}(mod {p})");
            if( a != 1 )
            {
                b = b * reverseElement.calcReverseElem(a, p) % p;
            }
            Console.WriteLine($"{n} ind(x) = ind({b})(mod {p-1})");
            

        }
        public void RevealingComparison()
        {

        }
    }
}
