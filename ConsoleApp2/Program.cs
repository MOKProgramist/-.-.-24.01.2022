using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            showMessage1(); // вызов первого метода showMessage1
            showMessage1();
            Console.WriteLine();
            showMessage2();
            showMessage2(); // вызов второго метода showMessage2
            Console.ReadKey();
        }
        static void showMessage1()
        {
            string[] kuxna = new string[4] { "Тарелка", "Чашка", "Кастрюля", "Сковорода"};
            for (int i = 0; i < kuxna.Length; i++) Console.WriteLine(kuxna[i]);
        }
        static void showMessage2()
        {
            string[] kuxna = new string[4] { "Стул", "Стол", "Кресло", "Диван" };
            for (int i = 0; i < kuxna.Length; i++) Console.WriteLine(kuxna[i]);
        }
    }
}

