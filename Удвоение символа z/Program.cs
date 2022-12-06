using System;

namespace Удвоение_символа_z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string a = str.Replace("z", "zz");
            Console.WriteLine(a);
        }
    }
}
