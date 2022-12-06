using System;

namespace Количество_пробелов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine(str.Length - str.Replace(" ", "").Length);
        }
    }
}
