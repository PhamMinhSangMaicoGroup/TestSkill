using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_Fibonancci
{
    class Way2
    {
        public int CreateNumFibonancci(int index,int[] arr)
        {
                if (index == 0  )
                {
                    return arr[0];
                }else if (index == 1)
                {
                    return arr[1];
                }
                else
                {
                    return CreateNumFibonancci(index - 1,arr) + CreateNumFibonancci(index - 2,arr);
                }
        }
        public int[] CreateArrayFibonancci(int num1,int num2,int length)
        {
            int[] arrFibonancci = new int[length];
            arrFibonancci[0] =num1;
            arrFibonancci[1] =num2;
            for (int i = 2; i < length; i++)
            {
                arrFibonancci[i] = CreateNumFibonancci(i,arrFibonancci);
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
