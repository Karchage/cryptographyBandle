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
        public static void calcCompare(int PrevX, int PrevMod, int ModNumber)
        {
            int GCDCount = GCD.countGcd(PrevX,ModNumber);
            if(PrevMod % GCDCount != 0)
            {
                Console.WriteLine("Error - can't find compare number");
            }
            else
            {
                Console.WriteLine($"Found {GCDCount} solutions");
                if(GCDCount != 1)
                {
                    PrevX /= GCDCount;
                    PrevMod /= GCDCount;
                    ModNumber /= GCDCount;
                    Console.WriteLine($"{PrevX}X= {PrevMod} (mod {ModNumber})");
                }
                int ResultNumber = (int)(Math.Pow(PrevX, EulerFunction.calcEulerFunction(ModNumber) - 1)) % ModNumber;
                if (ResultNumber < 0)
                    ResultNumber += ModNumber;
                Console.WriteLine($"ResultNumber of {PrevX} = {ResultNumber}");
                PrevX = ResultNumber * PrevX;
                PrevMod = ResultNumber * PrevMod;
                Console.WriteLine($"{PrevX}x = {PrevMod}(mod {ModNumber})");
                if(PrevX>ModNumber)
                {
                    PrevX %= ModNumber;
                }
                if (PrevMod > ModNumber)
                {
                    PrevMod %= ModNumber;
                }
                Console.WriteLine($"x = {PrevMod} + {ModNumber}k");
                for(int i = 0;i<GCDCount;i++)
                    Console.WriteLine($"x = {PrevMod+ModNumber*i} (mod {GCDCount*ModNumber})");

            }
        }
        //public static compare calcCompare(int prevX, int prevMod, int modNumber)
        //{   
        //    if(prevMod % GCD.countGcd(prevX,modNumber) != 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        if (GCD.countGcd(prevX, modNumber) != 1)
        //        {
        //                prevX /= GCD.countGcd(prevX, modNumber);
        //                prevMod /= GCD.countGcd(prevX, modNumber);
        //                modNumber /= GCD.countGcd(prevX, modNumber);
        //        }
        //        int returnNumber = (Int32)(Math.Pow(prevX, EulerFunction.calcEulerFunction(modNumber) - 1)) % modNumber;
        //        if(returnNumber < 0)
        //        {
        //            returnNumber += modNumber;
        //        }
        //        prevX = returnNumber * prevX;
        //        prevMod = returnNumber * prevMod;
        //        Console.WriteLine($"x = {prevMod} (mod {modNumber})");
        //        if( prevX > modNumber)
        //        {
        //            prevX = prevX % modNumber;
        //        }
        //        if(prevMod > modNumber)
        //        {
        //            prevMod = prevMod % modNumber;
        //        }
        //        Console.WriteLine($"x = {prevMod} + {modNumber}");
        //        for(var i = 0;i< GCD.countGcd(prevX, modNumber);i++)
        //        {
        //            Console.WriteLine($"x = {prevMod+modNumber*i}(mod {GCD.countGcd(prevX, modNumber)*modNumber})");
        //        }
        //        //prevX = (prevX * returnNumber) % modNumber;
        //        //prevMod = (prevMod * returnNumber) % modNumber;
        //        return new compare { firstNumberResult = prevMod, secondNumberResult = modNumber };
        //    }

        //}
    }
}
