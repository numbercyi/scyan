using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 8;
            Console.WriteLine( x == y);
            //false
            Console.WriteLine(x != y);
            //true
            Console.WriteLine(x > y );
            //false
            Console.WriteLine(x < y);
            //true
            Console.WriteLine(x >= y);
            //false
            Console.WriteLine(x <= y);
           //true
        }
    }
}
