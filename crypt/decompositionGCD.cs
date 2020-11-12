using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class decompositionGCD
    {
        public int decompX { get; set; }
        public int decompY { get; set; }
        public int result { get; set; }
        static public int countDegGCD(int firstNumber, int secondNumber,out int x,out int y)
        {

            if(secondNumber == 0)
            {
                x = 1;
                y = 0;
                return firstNumber;
            }
            int gcd = countDegGCD(secondNumber, firstNumber % secondNumber, out x, out y);
            int newX = y;
            int newY = x - (firstNumber / secondNumber) * y;
            x = newX;
            y = newY;
            return gcd;
            //int u1 = 1, u2 = 0, v1 = 0, v2 = 1;
            //int N = firstNumber, M = secondNumber;
            //while (secondNumber > 0)
            //{
            //    int q = firstNumber / secondNumber;
            //    int r = firstNumber % secondNumber;
            //    firstNumber = secondNumber;
            //    secondNumber = r;

            //    int tempU = u1 - u2 * q;
            //    u1 = u2;
            //    u2 = tempU;

            //    int tempV = v1 - v2 * q;
            //    v1 = v2;
            //    v2 = tempV;

            //}
            //return new decompositionGCD { decompU = u1, decompV = v1 };
        }
    }
}
