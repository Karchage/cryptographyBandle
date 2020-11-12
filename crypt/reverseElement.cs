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
        static public int calcReverseElem(int firstNumber, int secondNumber)
        {
            if(GCD.countGcd(firstNumber, secondNumber) != 1)
            {
                return 0;
            }
            else
            {
                int x,y, gcd = decompositionGCD.countDegGCD(firstNumber, secondNumber,out x,out y);
                while(x < 0)
                {
                    x = x + secondNumber;
                }
                return x;
            }


        }
    }
}
