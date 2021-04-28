using System;
using System.Collections.Generic;

namespace CSA_MethodSameLinQ
{
    class Program
    {
        // y tuong: stackoverflower
        static void Main(string[] args)
        {
            List<Data> listData = Data.ListData();

            Console.WriteLine("All data");
            foreach (var item in listData)
            {
                Console.WriteLine(item.Id + " : " + item.Name + " - " + item.Age);
            }

            //method where se vao Where trong FakeLinqList    
            var listDataWithAge23 = listData.FakeWhere(listData => listData.Age == 23);

            Console.WriteLine("\n\n------------------");
            Console.WriteLine("Data with age = 23");
            foreach (var item in listDataWithAge23)
            {
                Console.WriteLine(item.Id + " : " + item.Name + " - " + item.Age);
            }

            Console.WriteLine("\n\n------------------");
            Console.WriteLine("Data with ID = 2");
            Data dataWithIdIs2 = listData.FakeFind(dataWithIdIs2 => dataWithIdIs2.Id == "2");
            Console.WriteLine(dataWithIdIs2.Id + " : " + dataWithIdIs2.Name + " - " + dataWithIdIs2.Age);
            Console.ReadKey();
        }
    }
}
