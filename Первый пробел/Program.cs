using System;

namespace Первый_пробел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int b = str.IndexOf(" ");
            Console.WriteLine(b + 1);
        }
    }
}
