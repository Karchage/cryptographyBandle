using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    static public class reverseElement
    {
        static public Nullable<int> calcReverseElem(int firstNumber, int secondNumber)
        {
            try
            {
                if (GCD.countGcd(firstNumber, secondNumber) != 1)
                {
                    throw new Exception("Error - Not found reverse element");
                }
                else
                {
                    int x, y, gcd = decompositionGCD.countDegGCD(firstNumber, secondNumber, out x, out y);
                    while (x < 0)
                    {
                        x = x + secondNumber;
                    }
                    return x;
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
