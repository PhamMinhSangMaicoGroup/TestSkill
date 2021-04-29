using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_Fibonancci
{
    class Way3
    {
        public void PrintFibonancci(int num1, int num2)
        {
            Console.Write("[" + num1 + "]  ");
            Console.Write("[" + num2 + "]  ");

            
            for (int i = 0; i < 13; i++)
            {
                int numf = num1 + num2;
                Console.Write("[" + numf + "]  ");
                num1 = num2;
                num2 = numf;
            }
        }
    }
}
