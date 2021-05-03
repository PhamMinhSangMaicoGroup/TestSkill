using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_Fibonancci
{
    class Fibonacci
    {
        public static void menu()
        {
            int select = -1;
            do
            {
                try
                {
                    Console.WriteLine("========Menu=======");
                    Console.WriteLine("[1] Xuat 15 phan tu fibonacii voi 2 so dau tien tu nhap.");
                    Console.WriteLine("[2] Xuat chuoi fibonacci voi so phan tu tu nhap. ");
                    Console.WriteLine("[3] Kiem tra mot so co phai nam trong fibonacci khong va co thi nam o vi tri nao.");
                    Console.WriteLine("[0] Thoat.");
                    Console.Write("\t--> ");
                    select = Convert.ToInt32(Console.ReadLine());
                    

                    switch (select)
                    {
                        case 1:
                            {
                                CreateFibonacciWith2Element();
                                break;
                            }
                        case 2:
                            {
                                CreateFibonacciWithInputLength();
                                break;
                            }
                        case 3:
                            {
                                TakeValueAtInputLocation();
                                break;
                            }
                    }
                }
                catch (Exception exc)
                {
                    select = -1;
                }
                if (select<0||select>3)
                {
                    Console.WriteLine("\nNhap sai, moi nhap lai: ");
                }
            }while(select !=0);
            Console.WriteLine("\n\nEnd!\n");

        }

        public static void CreateFibonacciWith2Element()
        {
            int num1 = 0, num2 = 0;
            try
            {
                Console.WriteLine("num1 alway small than num2");
                Console.Write("Enter num1 : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter num2 : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 >= num2)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("input wrong!\n\n");
                return;
            }


            // Chỉ lấy 15 số trong chuỗi fibonancci
            int[] arrFibonancci = new int[15];

            //cach 1 
            Console.WriteLine("\ncach 1.");
            Way1 w1 = new Way1();
            arrFibonancci = w1.CreateArrayFibonancci(num1, num2,15);
            Console.Write("Fibonancci: ");
            w1.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 2
            Console.WriteLine("cach 2.");
            Way2 w2 = new Way2();
            arrFibonancci = w2.CreateArrayFibonancci(num1, num2,15);
            Console.Write("Fibonancci: ");
            w2.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 3 
            Console.WriteLine("cach 3.");
            Way3 w3 = new Way3();
            Console.Write("Fibonancci: ");
            w3.PrintFibonancci(num1, num2,15);
            Console.WriteLine("\n\n-------------------------------------\n");
        }
        public static void CreateFibonacciWithInputLength()
        {
            int length = 0;
            try
            {
                Console.Write("Enter length (>0): ");
                length = Convert.ToInt32(Console.ReadLine());
                if (length<=0)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("input wrong!\n\n");
                return;
            }

            // Chỉ lấy 15 số trong chuỗi fibonancci
            int[] arrFibonancci = new int[length];

            //cach 1 
            Console.WriteLine("\ncach 1.");
            Way1 w1 = new Way1();
            arrFibonancci = w1.CreateArrayFibonancci(0, 1, length);
            Console.Write("Fibonancci: ");
            w1.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 2
            Console.WriteLine("cach 2.");
            Way2 w2 = new Way2();
            arrFibonancci = w2.CreateArrayFibonancci(0, 1, length);
            Console.Write("Fibonancci: ");
            w2.PrintFibonancci(arrFibonancci);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 3 
            Console.WriteLine("cach 3.");
            Way3 w3 = new Way3();
            Console.Write("Fibonancci: ");
            w3.PrintFibonancci(0, 1, length);
            Console.WriteLine("\n\n-------------------------------------\n");
        }
        public static void TakeValueAtInputLocation()
        {
            // gioi han 40 vi de quy tren 40 rat mat thoi gian de tao chuoi
            int inputLocation = 0;
            try
            {
                Console.Write("Enter location (>=0 & <40): ");
                inputLocation = Convert.ToInt32(Console.ReadLine());
                if (inputLocation <0|| inputLocation>=100)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("input wrong!\n\n");
                return;
            }


            int[] arrFibonancci = new int[100];

            //cach 1 
            Console.WriteLine("\ncach 1.");
            Way1 w1 = new Way1();
            arrFibonancci = w1.CreateArrayFibonancci(0, 1, 40);
            Console.Write("Fibonancci: ");
            w1.TakeValueOfFibonacciAtLocal(arrFibonancci,inputLocation);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 2
            Console.WriteLine("cach 2.");
            Way2 w2 = new Way2();
            arrFibonancci = w2.CreateArrayFibonancci(0, 1, 40);
            Console.Write("Fibonancci: ");
            w2.TakeValueOfFibonacciAtLocal(arrFibonancci, inputLocation);
            Console.WriteLine("\n\n-------------------------------------\n");

            //cach 3 
            Console.WriteLine("cach 3.");
            Way3 w3 = new Way3();
            Console.Write("Fibonancci: ");
            w3.TakeValueOfFibonacciAtLocal(inputLocation);
            Console.WriteLine("\n\n-------------------------------------\n");
        }
    }
}
