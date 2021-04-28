using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_Fibonancci
{
    class Way3
    {
        public List<int> CreateListFibonacci()
        {
            List<int> listFibo = new List<int>();

            int num1 = 0, num2 = 1, numf = 0;
            // Khởi taọ trước 2 số đầu tiền trong dãy fibonacci
            listFibo.Add(0);
            listFibo.Add(1);

            for (int i = 0; i < 13; i++)
            {
                numf = num1 + num2;
                listFibo.Add(numf);
                num1 = num2;
                num2 = numf;
            }
            return listFibo;
        }
        public void PrintFibonancciWithList(List<int> listFibo)
        {
            foreach (int index in listFibo)
            {
                Console.Write("[" + index + "]  ");
            }
        }
    }
}
