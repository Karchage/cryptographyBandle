﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace crypt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"GCD(1234,54) = {GCD.countGcd(1234, 54)}");
            //Console.WriteLine($"GCD(123,5) = {GCD.countGcd(123, 5)}");
            //Console.WriteLine($"GCD(505,45) = {GCD.countGcd(505, 5)}");
            //Console.WriteLine($"GCD(287,4) = {GCD.countGcd(287, 7)}");
            //Console.WriteLine($"GCD(18,6) = {GCD.countGcd(55, 25)}");
            //int x, y;
            //Console.WriteLine(1234);
            //Console.WriteLine(54);
            //Console.WriteLine($"GCD(1234,54) = {decompositionGCD.countDegGCD(1234, 54, out x, out y)}");
            //Console.WriteLine($"(1234,54) = 1234 * {x} + 54 * {y}");

            //Console.WriteLine(655);
            //Console.WriteLine(5);
            //Console.WriteLine($"GCD(655,5) = {decompositionGCD.countDegGCD(655, 5, out x, out y)}");
            //Console.WriteLine($"(655,5) = 655 * {x} + 5 * {y}");

            //Console.WriteLine(387);
            //Console.WriteLine(7);
            //Console.WriteLine($"GCD(387,7) = {decompositionGCD.countDegGCD(387, 7, out x, out y)}");
            //Console.WriteLine($"(387,7) = 387 * {x} + 7 * {y}");


            //primeNumber.search(225);
            //Dictionary<int, int> mp = new Dictionary<int, int>();
            //mp = primeFactorization.count(12480);
            //primeFactorization.count(12480);
            //primeFactorization.count(65521);
            Console.WriteLine($"(1) = {EulerFunction.calcEulerFunction(1)}");
            Console.WriteLine($"(1234) = {EulerFunction.calcEulerFunction(1234)}");
            Console.WriteLine($"(874) = {EulerFunction.calcEulerFunction(874)}");
            Console.WriteLine($"(84848) = {EulerFunction.calcEulerFunction(84848)}");
            Console.WriteLine($"(364) = {EulerFunction.calcEulerFunction(364)}");
            //Console.WriteLine(reverseElement.calcReverseElem(250, 12480));
            //Console.WriteLine(reverseElement.calcReverseElem(65537, 78408));
            //Console.WriteLine(reverseElement.calcReverseElem(110, 17));
            //Console.WriteLine(reverseElement.calcReverseElem(56, 7845));
            //Console.WriteLine(reverseElement.calcReverseElem(87445, 654));

            //var res = compare.calcCompare(8, 4, 10);
            //Console.WriteLine($"{ res.firstNumberResult} , { res.secondNumberResult}");
            //var res1 = compare.calcCompare(27, 123, 5);
            //Console.WriteLine($"{ res1.firstNumberResult} , { res1.secondNumberResult}");
            //var res2 = compare.calcCompare(24, 35, 22);
            //if (res2 != null)
            //Console.WriteLine($"{ res2.firstNumberResult} , { res2.secondNumberResult}");
            //ChinesseAlgorithm.count(2);

            //Console.WriteLine(Jacobi.calcJacobi(26,126)); // -
            //Console.WriteLine(Jacobi.calcJacobi(47, 125)); // +
            //Console.WriteLine(Jacobi.calcJacobi(532, 2739)); // +
            //Console.WriteLine(Jacobi.calcJacobi(2204, 381)); //+

            //Console.WriteLine(LegendreSymbol.caltSymbol(-27,7)); //+
            //Console.WriteLine(LegendreSymbol.caltSymbol(12345,331));//+
            //Console.WriteLine(LegendreSymbol.caltSymbol(-131,283));//+

            //FindingDeduction.countDeduction(2, 5432675, 13); //+
            //FindingDeduction.countDeduction(3, 95813, 17); // +
            //FindingDeduction.countDeduction(22, 1345, 11);// +
            //FindingDeduction.countDeduction(2, 6754, 1155); // -
            //FindingDeduction.countDeduction(5, 765432, 4301);// -
            //AntiderivativeRoot.countRoot(7);
            //AntiderivativeRoot.countRoot(8);
            //AntiderivativeRoot.countRoot(9);
            //AntiderivativeRoot.countRoot(11);
            //AntiderivativeRoot.countRoot(12);
            //AntiderivativeRoot.countRoot(14);
        }

    }

}
