using System;

namespace NumInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름을 입력하세요");

            string name = Console.ReadLine();

            Console.WriteLine("나이를 입력하세요");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"나의 이름은 {name}, 나이는 {age}");

        {

        }
        }
    }
}
