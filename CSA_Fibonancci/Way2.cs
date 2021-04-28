using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_Fibonancci
{
    class Way2
    {
        public int CreateNumFibonancci(int index)
        {
            if (index == -1)
            {
                return -1;
            }
            else
            {
                if (index == 0 || index == 1)
                {
                    return index;
                }
                else
                {
                    return CreateNumFibonancci(index - 1) + CreateNumFibonancci(index - 2);
                }
            }
        }
        public int[] CreateArrayFibonancci()
        {
            int[] arrFibonancci = new int[15];
            for (int i = 0; i < 15; i++)
            {
                arrFibonancci[i] = CreateNumFibonancci(i);
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
    }
}
