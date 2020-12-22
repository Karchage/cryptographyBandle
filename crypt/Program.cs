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
            //Console.WriteLine($"GCD(287,7) = {GCD.countGcd(287, 7)}");
            //Console.WriteLine($"GCD(55,25) = {GCD.countGcd(55, 25)}");

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


            //Console.WriteLine($"(15) = {EulerFunction.calcEulerFunction(7)}");

            //Console.WriteLine();
            //for(var i = 1;i<7;i++)

            //int count = 0;
            //Console.WriteLine(i);
            //if(Math.Pow(i, 6 / 2) % 7 != 1)
            //{

            //}
            //if (Math.Pow(i, 6 / 3) % 7 != 1)
            //{
            //    count = 3;
            //}

            //Console.WriteLine(Math.Pow(i, 6 / 2) % 7);
            //Console.WriteLine(Math.Pow(i, 6 / 3) % 7);
            //Console.WriteLine(Math.Pow(i, 8 / 8) % 15);
            //Console.WriteLine(count);




            //Console.WriteLine($"(1234) = {EulerFunction.calcEulerFunction(1234)}");
            //Console.WriteLine($"(874) = {EulerFunction.calcEulerFunction(874)}");
            //Console.WriteLine($"(84848) = {EulerFunction.calcEulerFunction(84848)}");
            //Console.WriteLine($"(364) = {EulerFunction.calcEulerFunction(364)}");

            //Console.Write("reverse element for 25350, mod 1243280 response:");
            //Console.WriteLine(reverseElement.calcReverseElem(1, 4));


            //Console.Write("reverse element for 637, mod 788 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(637, 788));
            //Console.Write("reverse element for 10, mod 8 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(10, 8));
            //Console.Write("reverse element for 536, mod 78425 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(536, 78425));
            //Console.Write("reverse element for 875, mod 654 Response:");
            //Console.WriteLine(reverseElement.calcReverseElem(875, 654));
            //Console.WriteLine("7х = 3(mod 9)");
            //compare.calcCompare(7, 3, 9);
            //Console.WriteLine();

            //Console.WriteLine($"x = { res.firstNumberResult}(mod{ res.secondNumberResult})");
            //Console.WriteLine($"x = { res.firstNumberResult} + { res.secondNumberResult}k");
            //Console.WriteLine("10х = 15(mod 25)");
            //compare.calcCompare(10, 15, 25);
            //Console.WriteLine();

            //Console.WriteLine($"x = { res1.firstNumberResult}(mod{ res1.secondNumberResult})");
            //Console.WriteLine($"x = { res1.firstNumberResult} + { res1.secondNumberResult}k");
            //Console.WriteLine("25х = 15(mod 10)");
            //compare.calcCompare(25, 15, 10);
            //Console.WriteLine();



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

            Console.WriteLine("a = 2  k = 5432675  m = 13 ");
            FindingDeduction.countDeduction(2, 5432675, 13); //+
            Console.WriteLine();
            Console.WriteLine("a = 3  k = 95813  m = 17 ");
            FindingDeduction.countDeduction(3, 95813, 17); // +
            Console.WriteLine();
            Console.WriteLine("a = 2  k = 6754  m = 1155 ");
            FindingDeduction.countDeduction(2, 6754, 1155);// +
            Console.WriteLine();
            Console.WriteLine("a = 5  k = 765432  m = 4301 ");
            FindingDeduction.countDeduction(5, 765432, 4301); // -
            Console.WriteLine();


            //Console.WriteLine($"a X= k (mod m)");

            //Console.WriteLine("a = 2  k = 5432675  m = 13 ");
            //FindingDeduction.countDeduction(45, 27, 11);// -
            //Console.WriteLine();
            //Console.WriteLine("a = 3  k = 95813  m = 17 ");
            //FindingDeduction.countDeduction(3, 95813, 17);// -
            //Console.WriteLine();
            //Console.WriteLine("a = 2  k = 6754  m = 1155 ");
            //FindingDeduction.countDeduction(2, 6754, 1155);// -
            //Console.WriteLine();
            //Console.WriteLine("a = 3  k = 45723  m = 4862 ");
            //FindingDeduction.countDeduction(3, 45723, 4862);// -
            //Console.WriteLine();
            //Console.WriteLine("a = 2  k = 14562  m = 2277 ");
            //FindingDeduction.countDeduction(2, 14562, 2277);// -
            //Console.WriteLine();
            //Console.WriteLine("a = 2  k = 47385  m = 6545 ");
            //FindingDeduction.countDeduction(2, 47385, 6545);// -
            //Console.WriteLine();
            //Console.WriteLine("a = 2  k = 5432675  m = 13 ");
            //FindingDeduction.countDeduction(2, 5432675, 13);// +
            //Console.WriteLine();

            //Console.WriteLine("a = 24  k = 35  m = 2 ");
            //FindingDeduction.countDeduction(2, 6754, 1155);// +
            //Console.WriteLine();






            //Console.WriteLine(13);
            //AntiderivativeRoot.countRoot(13);
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

            //LinearConGenerator.PrintRandom(10);
        }

    }

}
