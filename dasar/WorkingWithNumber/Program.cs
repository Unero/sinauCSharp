using System;

namespace WorkingWithNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mathematic Operation
            Console.WriteLine(1 + 1);
            Console.WriteLine(1 - 1);
            Console.WriteLine(1 / 1);
            Console.WriteLine(1 * 1);
            Console.WriteLine(1 % 1);

            int num = 6;
            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(num--);

            Console.WriteLine(Math.Abs(-num));
            Console.WriteLine(Math.Pow(num, 2));
            Console.WriteLine(Math.Sqrt(Math.Pow(num, 2)));
            Console.WriteLine(Math.Max(num, 100));
            Console.WriteLine(Math.Min(num, 100));
            Console.WriteLine(Math.Round(5.1));
            Console.WriteLine(Math.PI);

            Console.ReadLine();
        }
    }
}
