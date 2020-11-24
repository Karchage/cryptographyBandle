using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class Jacobi
    {
        public static Nullable<int> calcJacobi(int firstNumber, int secondNumber)
        {
            try
            {
                if (!mutualSimplicity(firstNumber, secondNumber))
                {
                    throw new Exception("Error - not mutual simplicity number");
                }
                firstNumber = firstNumber % secondNumber;
                int t = 1;
                while (firstNumber != 0)
                {
                    while (firstNumber % 2 == 0)
                    {
                        firstNumber = firstNumber / 2;
                        int r = secondNumber % 8;
                        if (r == 3 || r == 5)
                        {
                            t = -t;
                        }
                    }
                    int temp = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = temp;
                    if (firstNumber % 4 == 3 && secondNumber % 4 == 3)
                    {
                        t = -t;
                    }
                    firstNumber = firstNumber % secondNumber;
                }
                if (secondNumber == 1)
                {
                    return t;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        static bool mutualSimplicity(int a, int b)
        {
            if (GCD.countGcd(a, b) == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
