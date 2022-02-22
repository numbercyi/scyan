using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "생명이 있는 동안 희망은 있다";

            int pos = str.IndexOf('희');

            string sub = str.Substring(pos);

            Console.WriteLine(sub);
        }
    }
}
