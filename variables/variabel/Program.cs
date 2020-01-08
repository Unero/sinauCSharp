using System;

namespace variabel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name = "John";
            int age = 35;

            Console.WriteLine("There once was a man named " + name);
            Console.WriteLine("He was " + age + " years old");

            // Variables are container of some value so you can change it by assign other value
            name = "Unknown";
            age = 99;
            Console.WriteLine("He really liked the name " + name);
            Console.WriteLine("But didn't like being " + age);
            Console.ReadLine();
        }
    }
}
