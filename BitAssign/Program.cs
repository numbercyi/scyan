using System;

namespace BitAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            x &= 3;
            Console.WriteLine("x &= 3; x = " + x);
            
            x |= 3;
            Console.WriteLine("x |= 3; x = " + x);
            x ^= 3;
            Console.WriteLine("x ^= 3; x = " + x);

            x = 4;
            x >>= 2;
            Console.WriteLine("x >> 2; x = " + x);
            x <<= 2;
            Console.WriteLine("x >> 2; x = " + x);


        }
    }
}
