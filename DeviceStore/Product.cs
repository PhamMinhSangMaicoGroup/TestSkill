using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceStore
{
    abstract class Product
    {
        private string productID;
        private int typeDevice;
        private string name;
        private double price;
        private string production;
        //set get
        public string ProductID { get => productID; set => productID = value; }
        public int TypeDevice { get => typeDevice; set => typeDevice = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Production { get => production; set => production = value; }

        //Contructor
        public Product() { }
        public Product(string productID, int typeDevice, string name, double price, string production)
        { this.ProductID = productID; this.TypeDevice = typeDevice; this.Name = name; this.Price = price; this.production = production; }

        public void Input()
        {
            Console.Write("Nhap ID:");
            productID = Console.ReadLine();
        }
        abstract public void Output();
    }
    abstract class Fan : Product
    {
        private int typeFan;

        public int TypeFan { get => typeFan; set => typeFan = value; }
        //Contructor
        public Fan() : base() { }
        public Fan(string productID, int typeDevice, string name, double price, string production, int typeFan) : base(productID, typeDevice, name, price, production)
        {
            this.typeFan = typeFan;
        }
        public void Input()
        {
            base.Input();

        }
        // Hồi làm xong cái này em chưa biết đến từ khóa Vitual nên không dùng
        // vì chạy vẫn ngon nên em không fix
        public override void Output()
        {
            Console.WriteLine("ID=" + base.ProductID);
            if (typeFan == 2)
            {
                Console.WriteLine("quat sac dien");
            }
            else if (typeFan == 1)
            {
                Console.WriteLine("quat hoi nuoc");
            }
            else
            {
                Console.WriteLine("quat thuong");
            }

        }

    }
    class SteamFan : Fan
    {
        private double capacity;

        public double Capacity { get => capacity; set => capacity = value; }

        public SteamFan() : base() { }
        public SteamFan(string productID, int typeDevice, string name, double price, string production, int typeFan, double capacity) : base(productID, typeDevice, name, price, production, typeFan)
        {
            this.Capacity = capacity;
        }

        //method
        public double SetPrice()
        {
            return capacity * 400;
        }
        public void Input()
        {
            base.Input();
            Console.Write("nhap ten:");
            Name = Console.ReadLine();
            Console.Write("dung tic binh:");
            do
            {
                try
                {
                    capacity = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    capacity = -1;
                }

                if (capacity <= 0)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (capacity <= 0);

            Price = SetPrice();
            Console.Write("Nhap hang:");
            Production = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("ten:" + Name);
            Console.WriteLine("dung tic" + capacity);
            Console.WriteLine("hang:" + Production);
            Console.WriteLine("Gia:" + SetPrice());
        }
    }
    class ElectricFan : Fan
    {
        private double battery;

        public double Battery { get => battery; set => battery = value; }
        //contructor
        public ElectricFan() : base() { }
        public ElectricFan(string productID, int typeDevice, string name, double price, string production, int typeFan, double battery) : base(productID, typeDevice, name, price, production, typeFan)
        {
            this.Battery = battery;
        }
        //method
        public double SetPrice()
        {
            return battery * 500;
        }
        public void Input()
        {
            base.Input();
            Console.Write("nhap ten:");
            Name = Console.ReadLine();
            Console.Write("dung tic pin:");
            do
            {
                try
                {
                    battery = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    battery = -1;
                }

                if (battery <= 0)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (battery <= 0);

            Price = SetPrice();
            Console.Write("Nhap hang:");
            Production = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("ten:" + Name);
            Console.WriteLine("dug tic pin" + battery);
            Console.WriteLine("hang:" + Production);
            Console.WriteLine("Gia:" + SetPrice());
        }
    }
    class NomalFan : Fan
    {

        //method
        public double SetPrice()
        {
            return 500;
        }
        public void Input()
        {
            base.Input();
            Console.Write("nhap ten:");
            Name = Console.ReadLine();


            Price = SetPrice();
            Console.Write("Nhap hang:");
            Production = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("ten:" + Name);
            Console.WriteLine("hang:" + Production);
            Console.WriteLine("Gia:" + SetPrice());
        }
    }
    //air-conditioner
    //
    abstract class AirConditioner : Product
    {
        private bool inventer;
        private int typeAir;

        public bool Inventer { get => inventer; set => inventer = value; }
        public int TypeAir { get => typeAir; set => typeAir = value; }

        public void Input()
        {
            base.Input();

        }
        public override void Output()
        {
            Console.WriteLine("ID=" + base.ProductID);
            if (typeAir == 1)
            {
                Console.WriteLine("loai may lanh 1 chieu");
            }
            else
            {
                Console.WriteLine("loai may lanh 2 chieu");
            }
            if (inventer)
            {
                Console.WriteLine("co inventer");
            }
            else
            {
                Console.WriteLine("ko co inventer");
            }
        }
    }
    class AirConditioner1Way : AirConditioner
    {

        //method
        public double SetPrice()
        {
            if (Inventer)
            {
                return 1500;
            }
            return 1000;
        }
        public void Input()
        {
            base.Input();
            Console.Write("co invert khong (1 co 2 khong):");
            int yn;
            do
            {
                try
                {
                    yn = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    yn = -1;
                }

                if (yn != 2 && yn != 1)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (yn != 2 && yn != 1);

            if (yn == 1)
            {
                Inventer = true;
            }
            else
            {
                Inventer = false;
            }
            Price = SetPrice();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Gia:" + SetPrice());
        }
    }
    class AirConditioner2Way : AirConditioner
    {
        private bool antimicrobial;
        private bool deodorant;

        public bool Antimicrobial { get => antimicrobial; set => antimicrobial = value; }
        public bool Deodorant { get => deodorant; set => deodorant = value; }

        //method
        public double SetPrice()
        {
            double price = 0;

            if (antimicrobial)
            {
                price += 500;
            }
            if (deodorant)
            {
                price += 500;
            }

            if (Inventer)
            {
                return 2500 + price;
            }
            return 2000 + price;

        }
        public void Input()
        {
            base.Input();
            Console.Write("co antimicrobial khong (1 co 2 khong):");
            int yn;
            do
            {
                try
                {
                    yn = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    yn = -1;
                }

                if (yn != 2 && yn != 1)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (yn != 2 && yn != 1);

            if (yn == 1)
            {
                antimicrobial = true;
            }
            else
            {
                antimicrobial = false;
            }
            Console.Write("co deodorant khong (1 co 2 khong):");
            int yn2;
            do
            {
                try
                {
                    yn2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    yn2 = -1;
                }
                if (yn2 != 2 && yn2 != 1)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (yn2 != 1 && yn2 != 2);

            if (yn2 == 1)
            {
                deodorant = true;
            }
            else
            {
                deodorant = false;
            }
            Console.Write("co invert khong (1 co 2 khong):");
            int yn3;
            do
            {
                try
                {
                    yn3 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exc)
                {
                    yn3 = -1;
                }
                if (yn3 != 2 && yn3 != 1)
                {
                    Console.Write("Nhap lai: ");
                }
            } while (yn3 != 2 && yn3 != 1);

            if (yn3 == 1)
            {
                Inventer = true;
            }
            else
            {
                Inventer = false;
            }
            Price = SetPrice();
        }
        public override void Output()
        {
            base.Output();
            if (antimicrobial)
            {
                Console.WriteLine("co antimicrobial");
            }
            else
            {
                Console.WriteLine("ko co antimicrobial");
            }
            if (deodorant)
            {
                Console.WriteLine("co deodorant");
            }
            else
            {
                Console.WriteLine("ko co deodorant");
            }
            Console.WriteLine("Gia:" + SetPrice());
        }
    }
}
