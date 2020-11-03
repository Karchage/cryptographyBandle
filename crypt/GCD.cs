using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public static class GCD
    {
        static public int countGcd(int firstNumber, int secondNumber)
        {
            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber = firstNumber % secondNumber;
                }
                else if (secondNumber > firstNumber)
                {
                    secondNumber = secondNumber % firstNumber;
                }
            }
            return (firstNumber + secondNumber);
        }
    }
}
