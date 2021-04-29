﻿using System;
using System.Collections.Generic;

namespace CSA_Fibonancci
{
    // mat khoang 20 phut
    class Program
    {
        static void Main(string[] args)
        {

            int num1=0, num2=0;
            try
            {
                Console.WriteLine("num1 alway small than num2");
                Console.Write("Enter num1 : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1>=num2)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("Nhap sai!\n\n");
                return;
            }


            // Chỉ lấy 15 số trong chuỗi fibonancci
            int[] arrFibonancci = new int[15];

            //cach 1 
            Console.WriteLine("cach 1.");
            Way1 w1 = new Way1();
            arrFibonancci = w1.CreateArrayFibonancci(num1, num2);
            Console.Write("Fibonancci: ");
            w1.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 2
            Console.WriteLine("cach 2.");
            Way2 w2 = new Way2();
            arrFibonancci = w2.CreateArrayFibonancci(num1,num2);
            Console.Write("Fibonancci: ");
            w2.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 3 
            Console.WriteLine("cach 3.");
            Way3 w3 = new Way3();
            Console.Write("Fibonancci: ");
            w3.PrintFibonancci(num1,num2);
            Console.WriteLine("\n\n-------------------------------------\n");

            Console.ReadKey();
        }
    }
}
