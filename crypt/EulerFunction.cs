using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    static public class EulerFunction
    {
        static public int calcEulerFunction(int number)
        {
            int resultNumber = number;
            for(int i =2; i*i<=number; ++i)
            {
                if(number % i == 0)
                {
                    while(number % i == 0)
                    {
                        number = number / i;
                    }
                    resultNumber -= resultNumber / i;
                }
            }
            if (number > 1)
            {
                resultNumber -= resultNumber / number;
            }
            return resultNumber;
        }
    }
}
