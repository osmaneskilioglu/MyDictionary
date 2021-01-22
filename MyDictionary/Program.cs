using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> age_name = new MyDictionary<int, string>();
            age_name.Add(34, "Yamaç Kocovali");
            age_name.Add(70, "İdris Kocovali");
            age_name.Add(42, "Cumali Kocovali");

            for (int i = 0; i < age_name.Length; i++)
            {
                Console.WriteLine("Age :" + age_name.GetKeys[i] + " - " + "Name Surname : " + age_name.GetValues[i]);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Number of Records: " + " " + age_name.Length);
            Console.ReadLine();
        }
    }
}