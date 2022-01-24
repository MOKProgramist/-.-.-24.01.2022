using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Введите число а = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b = ");
            int b = int.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine("А не может быть больше Б");
            }
            else
            {
                int res = GetSumNumber(a, b);

                Console.WriteLine(res);
            }
        }

        // функция с начальными значениями
        static int GetSumNumber(int a = 0, int b = 10)
        {
            // веменная переменная для суммы чисел от а до б
            int sum = 0;

            // вычисляем сумму
            for(int i = a; i <= b; i++)
            {
                sum += i;
                // Console.WriteLine(i);
            }

            return sum; 
        }
    }
}
