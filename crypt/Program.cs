using System;
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

            //Console.WriteLine("Finding prime number: 225");
            //primeNumber.search(225);

            //Dictionary<int, int> mp = new Dictionary<int, int>();
            //mp = primeFactorization.count(12480);
            //Console.WriteLine();
            //mp = primeFactorization.count(58585);
            //Console.WriteLine();
            //mp = primeFactorization.count(722772);
            //Console.WriteLine();
            //mp = primeFactorization.count(123);


            //Console.WriteLine($"(1) = {EulerFunction.calcEulerFunction(1)}");
            //Console.WriteLine($"(1234) = {EulerFunction.calcEulerFunction(1234)}");
            //Console.WriteLine($"(874) = {EulerFunction.calcEulerFunction(874)}");
            //Console.WriteLine($"(84848) = {EulerFunction.calcEulerFunction(84848)}");
            //Console.WriteLine($"(364) = {EulerFunction.calcEulerFunction(364)}");
            //Console.Write("25350,1243280 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(25350, 1243280));
            //Console.Write("637,788 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(637, 788));
            //Console.Write("10,8 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(10, 8));
            //Console.Write("536,78425 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(536, 78425));
            //Console.Write("875,654 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(875, 654));

            //var res = compare.calcCompare(24, 2, 1);
            //Console.WriteLine("24х = 2(mod 1)");
            //Console.WriteLine($"x = { res.firstNumberResult}(mod{ res.secondNumberResult})");
            //Console.WriteLine($"x = { res.firstNumberResult} + { res.secondNumberResult}k");
            //var res1 = compare.calcCompare(24, 12, 123);
            //Console.WriteLine();
            //Console.WriteLine("24х = 12(mod 123)");
            //Console.WriteLine($"x = { res1.firstNumberResult}(mod{ res1.secondNumberResult})");
            //Console.WriteLine($"x = { res1.firstNumberResult} + { res1.secondNumberResult}k");
            //var res2 = compare.calcCompare(24, 35, 22);
            //Console.WriteLine();
            //Console.WriteLine("24х = 35(mod 22)");
            //if (res2 != null)
            //{
            //    Console.WriteLine($"x = { res2.firstNumberResult}(mod{ res2.secondNumberResult})");
            //    Console.WriteLine($"x = { res2.firstNumberResult} + { res2.secondNumberResult}k");
            //}
            //else Console.WriteLine("No solutions");

            //List<int> bi = new List<int>() { 2, 4, 7 };
            //List<int> mi = new List<int>() { 5, 6, 7 };
            //List<int> bi = new List<int>() { 75, 6 };
            //List<int> mi = new List<int>() { 9, 150 };
            //for (var i = 0; i<mi.Count;i++)
            //{
            //    Console.WriteLine($"x = {bi[i]}(mod {mi[i]})");
            //}
            //ChinesseAlgorithm.count(bi, mi);

            //Console.Write("first number = 47, second number = 138 Response: ");
            //Console.WriteLine(Jacobi.calcJacobi(47, 138)); // +
            //Console.Write("first number = 532, second number = 2739 Response: ");
            //Console.WriteLine(Jacobi.calcJacobi(532, 2739)); // +
            //Console.Write("first number = 204, second number = 31 Response: ");
            //Console.WriteLine(Jacobi.calcJacobi(204, 31)); //+
            //Console.Write("first number = 25, second number = 125 Response: ");
            //Console.WriteLine(Jacobi.calcJacobi(25, 125)); // -

            //Console.Write("a = 133, p = 182 Response: ");
            //Console.WriteLine(LegendreSymbol.caltSymbol(133, 182));
            //Console.Write("a = -149, p = 157 Response: ");
            //Console.WriteLine(LegendreSymbol.caltSymbol(-149, 157));
            //Console.Write("a = -10, p = 120 Response: ");
            //Console.WriteLine(LegendreSymbol.caltSymbol(-10, 120));
            //Console.Write("a = 12345, p = 1234 Response: ");
            //Console.WriteLine(LegendreSymbol.caltSymbol(12345, 1234));
            //Console.Write("a = 121, p = 157 Response: ");
            //Console.WriteLine(LegendreSymbol.caltSymbol(121, 157));

            //Console.WriteLine("a = 45  k = 52675  m = 213 ");
            //FindingDeduction.countDeduction(45, 52675, 213); //+
            //Console.WriteLine();
            //Console.WriteLine("a = 35  k = 22313  m = 182 ");
            //FindingDeduction.countDeduction(35, 22313, 182); // +
            //Console.WriteLine();
            //Console.WriteLine("a = 123  k = 12345  m = 12 ");
            //FindingDeduction.countDeduction(123, 12345, 12);// +
            //Console.WriteLine();
            //Console.WriteLine("a = 1  k = 2  m = 3 ");
            //FindingDeduction.countDeduction(1, 2, 3); // -
            //Console.WriteLine();
            //Console.WriteLine("a = 10  k = 100  m = 1000 ");
            //FindingDeduction.countDeduction(10, 100, 1000);// -

            //Console.WriteLine(12);
            //AntiderivativeRoot.countRoot(12);
            //Console.WriteLine();
            //Console.WriteLine(11);
            //AntiderivativeRoot.countRoot(11);
            //Console.WriteLine();
            //Console.WriteLine(22);
            //AntiderivativeRoot.countRoot(22);
            //Console.WriteLine();
            //Console.WriteLine(13);
            //AntiderivativeRoot.countRoot(13);
            //Console.WriteLine();
            //Console.WriteLine(9);
            //AntiderivativeRoot.countRoot(9);
            //Console.WriteLine();
            //Console.WriteLine(8);
            //AntiderivativeRoot.countRoot(8);

            LinearConGenerator.PrintRandom(10);
        }

    }

}
