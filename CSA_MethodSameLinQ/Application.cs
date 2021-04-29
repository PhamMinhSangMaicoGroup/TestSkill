using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_MethodSameLinQ
{
    class Application
    {
        public Data CreateData()
        {
            Data data = new Data();
            Console.Write("Enter ID : ");
            data.Id = Console.ReadLine();
            Console.Write("Enter name : ");
            data.Name = Console.ReadLine();

            do
            {
                Console.Write("Enter age : ");
                try
                {
                    data.Age = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception exc)
                {
                    data.Age = -1;
                }
                if (data.Age == -1)
                {
                    Console.WriteLine("Nhap sai nhap lai.");
                }
            } while (data.Age < 0);
            return data;
        }
        public void ShowData(Data data)
        {
            Console.WriteLine("\t* " + data.Id + " : " + data.Name + " - " + data.Age);
        }
        public void ShowAllDatas(List<Data> listDatas)
        {
            if (listDatas.Count == 0)
            {
                Console.WriteLine("Dont have data...");
            }
            foreach (var data in listDatas)
            {
                Console.WriteLine("\t* " + data.Id + " : " + data.Name + " - " + data.Age);
            }
        }
        public string AttributeFilter()
        {
            string findElement = "";
            int numSelect = -1;
            do
            {
                Console.WriteLine("\nYou want to filter by which attribute:");
                Console.WriteLine("[1] ID");
                Console.WriteLine("[2] Name");
                Console.WriteLine("[3] Age");

                Console.Write("\t -> ");
                try
                {
                    numSelect = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    numSelect = -1;
                }

                switch (numSelect)
                {
                    case 1:
                        {
                            findElement = "Id";
                            break;
                        }
                    case 2:
                        {
                            findElement = "Name";
                            break;
                        }
                    case 3:
                        {
                            findElement = "Age";
                            break;
                        }

                }
                if (numSelect < 1 || numSelect > 3)
                {
                    Console.WriteLine("Nhap sai, moi nhap lai!");
                }
            } while (numSelect < 1 || numSelect > 3);

            return findElement;
        }
        public string ValueOfAttributeNeedFilter(List<Data> listDatas, out string attribute)
        {
            attribute = AttributeFilter();
            switch (attribute)
            {
                case "Id":
                    {
                        Console.Write("Enter ID : ");
                        string id = Console.ReadLine();
                        return id;

                    }
                case "Name":
                    {
                        Console.Write("Enter Name : ");
                        string name = Console.ReadLine();
                        return name;
                    }
                case "Age":
                    {
                        Console.Write("Enter ID : ");
                        int age = -1;
                        do
                        {
                            try
                            {
                                age = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (Exception exc)
                            {
                                age = -1;
                            }
                            if (age == -1)
                            {
                                Console.WriteLine("Nhap sai nhap lai.");
                            }
                        } while (age < 0);


                        return age.ToString();
                    }

            }
            return "";
        }


        public void Menu()
        {
            Console.WriteLine("********** Wellcome to MethodSamilarLinQ **********");
            int numSelect = -1;
            List<Data> listDatas = new List<Data>();
            do
            {
                Console.WriteLine("\n\n\n---- Please select one function ----");
                Console.WriteLine("[1] Create data");
                Console.WriteLine("[2] Show full data");
                Console.WriteLine("[3] Filter data with Find()");
                Console.WriteLine("[4] Filter data with Where()");
                Console.WriteLine("[0] Exit!");
                Console.Write("\t -> ");
                try
                {
                    numSelect = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception exc)
                {
                    numSelect = -1;
                }

                switch (numSelect)
                {
                    case 1:
                        {
                            Data newData = new Data();
                            newData = CreateData();
                            listDatas.Add(newData);
                            break;
                        }
                    case 2:
                        {
                            ShowAllDatas(listDatas);
                            break;
                        }
                    case 3:
                        {
                            string attribute;
                            string value = ValueOfAttributeNeedFilter(listDatas, out attribute);
                            Data dataWithFind;
                            if (attribute == "Id")
                            {
                                dataWithFind = listDatas.FakeFind(dataWithFind => dataWithFind.Id == value);
                            }
                            else
                            if (attribute == "Name")
                            {
                                dataWithFind = listDatas.FakeFind(dataWithFind => dataWithFind.Name == value);
                            }
                            else
                            if (attribute == "Age")
                            {
                                dataWithFind = listDatas.FakeFind(dataWithFind => dataWithFind.Age == Convert.ToInt32(value));
                            }
                            else
                            {
                                dataWithFind = new Data();
                                
                            }
                            ShowData(dataWithFind);
                            break;
                        }
                    case 4:
                        {
                            string attribute;
                            string value = ValueOfAttributeNeedFilter(listDatas, out attribute);
                            if (attribute == "Id")
                            {
                                var ListDatasWithFind = listDatas.FakeWhere(ListDatasWithFind => ListDatasWithFind.Id == value);
                                foreach (var data in ListDatasWithFind)
                                {
                                    ShowData(data);
                                    
                                }
                            }
                            if (attribute == "Name")
                            {
                                var ListDatasWithFind = listDatas.FakeWhere(ListDatasWithFind => ListDatasWithFind.Name == value);
                                foreach (var data in ListDatasWithFind)
                                {
                                    ShowData(data);
                                }
                            }
                            if (attribute == "Age")
                            {
                                var ListDatasWithFind = listDatas.FakeWhere(ListDatasWithFind => ListDatasWithFind.Age == Convert.ToInt32(value));
                                foreach (var data in ListDatasWithFind)
                                {
                                    ShowData(data);
                                }
                            }

                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                }
            } while (numSelect != 0);
        }
    }
}
