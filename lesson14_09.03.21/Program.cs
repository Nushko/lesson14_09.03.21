//Вчера не успел сделать дз из-за универа
//
using System;
using System.Collections.Generic;

namespace lesson14_09._03._21
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new MyList<int>();
            x.Add(4);
            x.Add(4);
            x.Insert(1, 7);
            x.Add(4);
            x.FindAll();
            x.Find(100);
            Console.WriteLine("\n" + x.Count);
            Console.WriteLine(new string('-', 20));

            var t = new MyDictionary<int, string>();
            t.Add(4, "бутер");
            t.Add(2, "вкусный");
            t.Add(1, "очень");
            Console.WriteLine(t.Count);
            Console.WriteLine(t.FindByKey(4));
            Console.WriteLine(t.FindByKey(1));
            Console.WriteLine(t.FindByKey(2));
            Console.WriteLine(t.FindByKey(10));
        }
    }

}
