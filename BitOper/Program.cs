using System;

namespace BitOper
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 15;

            Console.WriteLine("x & y = " + (x&y));
            
            Console.WriteLine("x | y = " + (x|y));
            
            Console.WriteLine("x ^ y = " + (x^y));
            
            Console.WriteLine("~x =" + (~x));
            
            Console.WriteLine("x << 2 = " + (x << 2));

            Console.WriteLine("x >> 2 = " + (x >> 2));



        }
    }
}
