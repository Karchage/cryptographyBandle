using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public static class decompositionGCD
    {
        static public string countDegGCD(int firstNumber, int secondNumber)
        {
            int u1 = 1, u2 = 0, v1 = 0, v2 = 1;
            int N = firstNumber, M = secondNumber;
            while (secondNumber != 0)
            {
                int q = firstNumber / secondNumber;
                int r = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = r;

                int tempU = u1 - u2 * q;
                u1 = u2;
                u2 = tempU;

                int tempV = v1 - v2 * q;
                v1 = v2;
                v2 = tempV;
            }
            string ret = N + "*" + u1 + "+" + M + "*" + v1;
            return ret;
        }
    }
}
