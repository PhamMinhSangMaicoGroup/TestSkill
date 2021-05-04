using System;

namespace DeviceStore
{
    // thoi gian lam tam 4 tieng

    class Program
    {
        static void Main(string[] args)
        {
            ListBill listBill = new ListBill();
            listBill.Input();
            listBill.Output();
            Console.ReadKey();
        }
    }
}
