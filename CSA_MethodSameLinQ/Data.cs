using System;
using System.Collections.Generic;
using System.Text;

namespace CSA_MethodSameLinQ
{
    class Data
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        //Contructor
        public Data() { }
        public Data(string id,String name,int age)
        {
            Id = id; Name = name; Age = age;
        }
        public static List<Data> ListData()
        {
            List<Data> list = new List<Data>
            {
                new Data("1","Pham Minh Sang",21),
                new Data("2","Minh Pham Sang",22),
                new Data("3","Sang Minh Pham",23),
                new Data("4","Pham Sang Minh",23)
            };
            return list;
        }

        
    }
}
