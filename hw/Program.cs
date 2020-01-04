using System;
using System.Collections.Generic;
using hw1;
namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            string[] aa = {"asd", "shakir"};
            List<Object> myObjList = new List<Object>();
            Dictionary<string, string> myKeyVal = new Dictionary<string, string>();
            myKeyVal.Add("asd", "asd");
            myKeyVal.Add("aa", "ass");
            myObjList.Add(myKeyVal);
            Console.WriteLine(myKeyVal.Count.ToString());
            foreach (var item in aa)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hello World!");
            p.name = "shakir";
            Console.WriteLine(p.name);
            new person.metoo();
        }
    }
}
