using System;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escape String
            Console.WriteLine("Unero\nAcademy"); // New Line
            Console.WriteLine("Unero\"Academy\""); // Produce ""

            string name = "Unero Academy " + "is Cool!";
            Console.WriteLine(name);
            Console.WriteLine(name.ToUpper()); // UPPERCASE
            Console.WriteLine(name.Length); // get length of string
            Console.WriteLine(name.Contains("a")); // Search string in strings
            Console.WriteLine(name[0]);
            Console.WriteLine(name.IndexOf("Academy"));
            // Substring
            Console.WriteLine(name.Substring(7));
            Console.WriteLine(name.Substring(7,3));

            Console.ReadLine();
        }
    }
}
