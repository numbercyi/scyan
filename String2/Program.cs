using System;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            string na = "대한민국";
            string city = "서울특별시";
            string add = string.Concat(na, city);
            Console.WriteLine(add);
        }
    }
}
