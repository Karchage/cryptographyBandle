using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypt
{
    public class primeNumber
    {
        static public void search(int number)
        {
            int[] mas = new int[number];
            int i, j, k, ch = 0;
            for(i = 1; 3*i+1 < number; i++)
            {
                for(j = 1; (k=i+j+2*i*j) < number && j<=i; j++)
                {
                    mas[k] = 1;
                }
            }

            for(i = 1; i< number;i++)
            {
                if(mas[i] == 0)
                {
                    ch = 2 * i + 1;
                    if(ch<number)
                    {
                        Console.Write(ch + " ");
                    }
                }
            }
        }
    }
}
