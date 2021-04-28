using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceStore
{
    class Customer
    {
        public string ma { set; get; }
        public string ten { set; get; }
        public string addr { set; get; }
        public string sdt { set; get; }
        public void Input()
        {
            Console.Write("Nhap ID:");
            ma = Console.ReadLine();
            Console.Write("Nhap ten:");
            ten = Console.ReadLine();
            Console.Write("Nhap addr:");
            addr = Console.ReadLine();
            Console.Write("Nhap sdt:");
            sdt = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("ID=" + ma);
            Console.WriteLine("ten=" + ten);
            Console.WriteLine("dia chi=" + addr);
            Console.WriteLine("sdt=" + sdt);
        }
    }
}
