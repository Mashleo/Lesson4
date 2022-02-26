using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите число от 0 до 100: ");
            int value = int.Parse(Console.ReadLine());
            
            if (value >= 0 && value <= 30)
            {
                Console.WriteLine("Число находится в промежетке 0-30");
            }
            else if (value >= 31 && value <= 60)
            {
                Console.WriteLine("Число находится в промежетке 31-60");
            }
            else if (value >= 61 && value <= 100)
            {
                Console.WriteLine("Число находится в промежетке 60-100");
            }
            else
            {
                Console.WriteLine("Я такого числа не знаю");
            }
        }
    }
}
