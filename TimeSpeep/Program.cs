using System;

namespace TimeSpeep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            getSleepTine(17);

            getSleepTine(15);

            getSleepTine(21);

            getSleepTine(23);
        }

        static void getSleepTine(int hour)
        {
            if (hour < 21)
            {
                Console.WriteLine("Еще рано спать! Время: {0}", hour);
                return;
            }
            else
            {
                Console.WriteLine("Пора ложиться спать. Время: {0}", hour);
            }
        }
    }
}
