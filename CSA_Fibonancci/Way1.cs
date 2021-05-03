using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_Fibonancci
{
    class Way1
    {
        public int[] CreateArrayFibonancci(int num1, int num2,int length) //num1,2 là 2 số đầu của chuỗi
        {
            int[] arrFibonancci = new int[length];
            // set 2 số đầu vào array
            arrFibonancci[0] = num1;
            arrFibonancci[1] = num2;
            for (int i = 2; i < length; i++)
            {
                arrFibonancci[i] = arrFibonancci[i - 1] + arrFibonancci[i - 2];
            }
            return arrFibonancci;
        }
        public void PrintFibonancci(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[" + arr[i] + "]  ");
            }
        }
        public void TakeValueOfFibonacciAtLocal(int[] arr, int local)
        {
            Console.WriteLine("\nValue at Local: [" + local + "] = " + arr[local]);
            Console.WriteLine();
        }
    }
}
