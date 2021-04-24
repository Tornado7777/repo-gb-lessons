using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введите ваше имя:");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
            Console.ReadLine();

        }
    }
}
