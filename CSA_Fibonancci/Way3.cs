using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_Fibonancci
{
    class Way3
    {
        public void PrintFibonancci(int num1, int num2,int length)
        {
            Console.Write("[" + num1 + "]  ");
            Console.Write("[" + num2 + "]  ");

            
            for (int i = 2; i < length; i++)
            {
                int numf = num1 + num2;
                Console.Write("[" + numf + "]  ");
                num1 = num2;
                num2 = numf;
            }
        }
        public void TakeValueOfFibonacciAtLocal( int local)
        {
            int num1=0,num2 = 1,numf=-1;
            for (int i = 2; i < local+1; i++)
            {
                numf = num1 + num2;
                num1 = num2;
                num2 = numf;
            }
            Console.WriteLine("\nValue at Local: [" + local + "] = " + numf);
            Console.WriteLine();
        }
    }
}
