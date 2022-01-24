using System;

namespace getAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            getAge(17);
        }

        static void getAge(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("Вы несовершеннолетний");
                return;
            }
            else
            {
                Console.WriteLine("Вы совершеннолетний");
            }
        }
    }
}
