using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetHello();
            int sum = GetMult();

            Console.WriteLine(message);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static string GetHello()
        {
            return "Hello";
        }
        static int GetMult()
        {
            int x = 12;
            int y = 44;
            return x*y;
        }
    }
}
