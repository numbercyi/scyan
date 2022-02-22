using System;

namespace Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;

            Console.WriteLine(x);
            //30
            Console.WriteLine(x += 7);
            //37
            Console.WriteLine(x -= 7);
            //30
            Console.WriteLine(x *= 7);
            //210
            Console.WriteLine(x /= 7);
            //30
            Console.WriteLine(x %= 7);
            //2
        }
    }
}
