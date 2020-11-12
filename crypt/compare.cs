using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class compare
    {
        public int firstNumberResult { get; set; }
        public int secondNumberResult { get; set; }
        public static compare calcCompare(int prevX, int prevMod, int modNumber)
        {   // a b m
            // prevX X = prevMod(mod modNumber)
            if(GCD.countGcd(prevX,modNumber)  != 1)
            {
                if(prevMod % GCD.countGcd(prevX, modNumber) == 0)
                {
                    prevX /= GCD.countGcd(prevX, modNumber);
                    prevMod /= GCD.countGcd(prevX, modNumber);
                    modNumber /= GCD.countGcd(prevX, modNumber);
                }
                else
                {
                    return null;
                }
            }
            int returnNumber = (Int32)(Math.Pow(prevX, EulerFunction.calcEulerFunction(modNumber) - 1)) % modNumber;
            prevX = (prevX * returnNumber) % modNumber;
            prevMod = (prevMod * returnNumber) % modNumber;
            return new compare {firstNumberResult = prevMod, secondNumberResult = modNumber };
        }
    }
}
