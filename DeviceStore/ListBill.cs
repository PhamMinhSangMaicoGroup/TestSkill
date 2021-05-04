using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceStore
{
    class ListBill
    {
        Bill[] listBills;
        public void Input()
        {
            int listBillsLength = -1;
            do
            {
                Console.Write("\nNhap so luong don hang:");

                try
                {
                    listBillsLength = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    listBillsLength = -1;
                }
                if (listBillsLength <= 0)
                {
                    Console.Write("Nhap sai, nhap lai - ");
                }
            } while (listBillsLength <= 0);
            listBills = new Bill[listBillsLength];
            for (int i=0;i<listBillsLength;i++)
            {
                listBills[i] = new Bill();
                listBills[i].Input();
            }
            
        }
        public void Output()
        {
            int index = 0;
            listBills[index].Output();
            Console.WriteLine("\n\n bam a de sang trai, d de sang phai., q de thoat ");
            string click;
            do
            {
                click = Console.ReadKey().KeyChar.ToString() ;
                int indexBef = index;
                string notify="";
                if (click!="a"|| click != "d"|| click != "q")
                {
                    Console.WriteLine("Nhap sai nut!");
                }

                if (click == "q")
                {
                    break;
                }

                if (click == "a")
                {
                    index--;
                    if (index<0)
                    {
                        notify = "Khong the sang trai duoc nua";
                    }
                }
                else if (click == "d")
                {
                    index++;
                    if (index >=listBills.Length )
                    {
                        notify = "Khong the sang phai duoc nua";
                    }
                }
                else 
                {
                    index = -1; 
                }

                if (index < 0 || index >= listBills.Length)
                {

                    Console.WriteLine(notify);
                    index = indexBef;
                }
                else
                {
                    listBills[index].Output();
                    Console.WriteLine("\n\n bam a de sang trai, d de sang phai., q de thoat ");
                }

            } while (click != "q");
            for (int i = 0; i < listBills.Length; i++)
            {
                Console.WriteLine("=======Bill ["+(i+1)+"]=======");
                listBills[i].Output();
                Console.WriteLine("\n=====================\n");
                
            }
        }
    }
}
