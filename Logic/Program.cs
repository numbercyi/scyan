using System;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            Console.WriteLine(x < 7 && x < 10);
            //false
            Console.WriteLine(x < 7 || x < 10);
            //true
            Console.WriteLine(!(x>7 && x<10));
            //false
        }
    }
}
