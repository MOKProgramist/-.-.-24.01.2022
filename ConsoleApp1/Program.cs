using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // вычисление
            for (int i = 0; i < 20; i++)
            {
                int res = calculatingX(i);

                Console.WriteLine(res);
            }
        }
        // метод вычисления по формуле
        static int calculatingX(int x)
        {
            int y = x * x;
            return y;
        }
    }
}
