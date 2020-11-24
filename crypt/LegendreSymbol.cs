using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class LegendreSymbol
    {
        static public Nullable<int> caltSymbol(int a,int p )
        {
            try
            {
                if(!FindingDeduction.trial_div(p))
                {
                    throw new Exception("Error - Composite number");
                }
                else
                {
                    if (a == 1)
                    {
                        return 1;
                    }
                    int? l;
                    if (a % 2 == 0)
                    {
                        l = caltSymbol(a / 2, p) * (int)(Math.Pow((-1), (Math.Pow(p, 2) - 1) / 8));
                    }
                    else
                    {
                        l = caltSymbol(p % a, a) * (int)(Math.Pow((-1), ((a - 1) * (p - 1) / 4)));
                    }
                    return l;
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
    }
}
