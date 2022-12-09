using System;
using System.Linq;

namespace Знаки_препинания
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = str.Count(char.IsPunctuation);
            Console.WriteLine(a);
        }
    }
}
