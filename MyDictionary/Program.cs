using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDicList<int, string> products = new MyDicList<int, string>();
            products.Add(1,"kalem");
            Console.WriteLine(products.Length);
            products.Add(2,"silgi");
            Console.WriteLine(products.Length);
            products.Add(3,"defter");
            Console.WriteLine(products.Length);
            products.Add(4, "kitap");
            Console.WriteLine(products.Length);
            
        }
    }
}