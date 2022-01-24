using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] map = new char[] { '_', '_', '!', '_', '_', '_' };

            string[] b = new string[map.Length];

            // создаем масив символов в стринг
            for (int i = 0; i < map.Length; i++) b[i] = map[i].ToString();
            

            Generate(b);

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }
        }

        // замена символов в массиве
        static void Generate(string[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = "C# ";
            }
        }

    }
}
