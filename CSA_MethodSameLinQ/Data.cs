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

    }
}
