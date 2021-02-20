using System;
using System.Collections.Generic;

namespace MyDictionaryList
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<int, string>();
            users.Add(1, "Mike");
            users.Add(2, "Tom");


            foreach (var user in users)
            {
                Console.WriteLine("ID:" + user.Key + " " + "Name Surname:" + user.Value); ;
            }
            Console.WriteLine("\n");

            MyDictionary<int, string> users1 = new MyDictionary<int, string>();
            users1.Add(1, "Cash");
            users1.Add(2, "Hally");
            users1.Add(3, "Mary");

            users1.List();

        }
    }
}
