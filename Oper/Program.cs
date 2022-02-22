using System;

namespace Oper
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 2;

            Console.WriteLine(x + y);
            //9
            Console.WriteLine(x - y);
            //5
            Console.WriteLine(x * y);
            //14
            Console.WriteLine(x / y);
            //3?
            Console.WriteLine(x % y);
            //1
            Console.WriteLine(++x);
            //8
            Console.WriteLine(--y);
            //1

        }
    }
}
