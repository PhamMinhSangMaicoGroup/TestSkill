using System;
using System.Collections.Generic;

namespace CSA_Fibonancci
{
    // mat khoang 20 phut
    class Program
    {
        static void Main(string[] args)
        {
            // Chỉ lấy 15 số trong chuỗi fibonancci
            int[] arrFibonancci = new int[15];

            //cach 1 dùng for
            Console.WriteLine("cach 1.");
            Way1 w1 = new Way1();
            arrFibonancci = w1.CreateArrayFibonancci(0, 1);
            Console.Write("Fibonancci: ");
            w1.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 2 dùng de quy
            Console.WriteLine("cach 2.");
            Way2 w2 = new Way2();
            arrFibonancci = w2.CreateArrayFibonancci();
            Console.Write("Fibonancci: ");
            w2.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 3 dùng list
            Console.WriteLine("cach 3.");
            Way3 w3 = new Way3();
            List<int> listFibonancci = w3.CreateListFibonacci();
            Console.Write("Fibonancci: ");
            w3.PrintFibonancciWithList(listFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            Console.ReadKey();
        }
    }
}
