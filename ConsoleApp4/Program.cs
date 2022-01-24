using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // вызов методов 2 раза.
            for(int i = 0; i < 2; i++)
            {
                goodByeMethod();
                helloMethod();
            }
        }
        // метод прощания
        static void goodByeMethod()
        {
            Console.WriteLine("GoodBye!");
        }
        // метод приветствия
        static void helloMethod()
        {
            Console.WriteLine("Hello!");
        }
    }
}
