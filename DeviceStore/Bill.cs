using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceStore
{
    class Bill
    {
        //Properties
        private string billID;
        private string customerID;
        private int billUnit;
        private string dateCreated;
        private double totalMoney;

        public string BillID { get => billID; set => billID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string DateCreated { get => dateCreated; set => dateCreated = value; }
        public double TotalMoney { get => totalMoney; set => totalMoney = value; }
        public int BillUnit { get => billUnit; set => billUnit = value; }

        Customer cus;
        Product[] listProd;
        //method
        public void Input()
        {
            listProd = new Product[100];

            totalMoney = 0;

            cus = new Customer();
            Console.Write("Nhap ma hoa don:");
            BillID = Console.ReadLine();
            Console.Write("Nhap ngay lap don:");
            DateCreated = Console.ReadLine();
            Console.WriteLine("Nhap thong tin khach hang:");
            cus.Input();
            do
            {
                Console.Write("Nhap so luong chi tiet don:");

                try
                {
                    BillUnit = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    BillUnit = -1;
                }
                if (BillUnit <= 0)
                {
                    Console.Write("Nhap sai, nhap lai - ");
                }
            } while (BillUnit <= 0);

            for (int i = 0; i < BillUnit; i++)
            {
                Console.WriteLine("nhap chi tiet hoa don " + (i + 1) + ":");
                Console.Write("Chon loai thiet bi dien (1-may quat, 2- may lanh):");
                int typeDevice;
                do
                {
                    try
                    {
                        typeDevice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception exc)
                    {
                        typeDevice = 0;
                    }
                    if (typeDevice < 1 || typeDevice > 2)
                    {
                        Console.Write("Nhap sai, nhap lai - ");
                    }
                } while (typeDevice < 1 || typeDevice > 2);

                switch (typeDevice)
                {
                    case 1:
                        {
                            Console.Write("Chon loai quat (1-hoi nuoc, 2-pin dien, 3-quat thuong):");
                            int typeFan = Convert.ToInt32(Console.ReadLine());
                            switch (typeFan)
                            {
                                case 1:
                                    {
                                        SteamFan prod = new SteamFan();
                                        prod.TypeDevice = 1;
                                        prod.TypeFan = 1;
                                        prod.Input();
                                        Console.Write("so luong:");
                                        int sl = Convert.ToInt32(Console.ReadLine());
                                        totalMoney += prod.Price * sl;
                                        listProd[i] = new SteamFan();
                                        listProd[i] = prod;
                                        break;
                                    }
                                case 2:
                                    {
                                        ElectricFan prod = new ElectricFan();
                                        prod.TypeDevice = 1;
                                        prod.TypeFan = 2;
                                        prod.Input();
                                        listProd[i] = new ElectricFan();
                                        listProd[i] = prod;
                                        break;
                                    }
                                case 3:
                                    {
                                        NomalFan prod = new NomalFan();
                                        prod.TypeDevice = 1;
                                        prod.TypeFan = 3;
                                        prod.Input();
                                        listProd[i] = new NomalFan();
                                        listProd[i] = prod;
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Chon loai may lanh (1-1 chieu, 2-2 chieu):");
                            int typeAir = Convert.ToInt32(Console.ReadLine());
                            switch (typeAir)
                            {
                                case 1:
                                    {
                                        AirConditioner1Way prod = new AirConditioner1Way();
                                        prod.TypeDevice = 2;
                                        prod.TypeAir = 1;
                                        prod.Input();
                                        listProd[i] = new AirConditioner1Way();
                                        listProd[i] = prod;
                                        break;
                                    }
                                case 2:
                                    {
                                        AirConditioner2Way prod = new AirConditioner2Way();
                                        prod.TypeDevice = 2;
                                        prod.TypeAir = 2;
                                        prod.Input();
                                        listProd[i] = new AirConditioner2Way();
                                        listProd[i] = prod;
                                        break;
                                    }
                            }
                            break;
                        }
                }


            }

        }
        public void Output()
        {
            Console.WriteLine("=========Thong tin khach hang========");
            cus.Output();
            Console.WriteLine("=========Chi tiet hoa don========");
            for (int i = 0; i < BillUnit; i++)// chứa các loại hàng đã chọn
            {
                Console.WriteLine("\t --{0}-- \t", i + 1);
                listProd[i].Output();
                totalMoney += listProd[i].Price;
            }
            Console.WriteLine("=====================");
            Console.WriteLine("Tong tien:" + TotalMoney);
        }
    }
}
