using System;

namespace Удаление_символов
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] array = Console.ReadLine().Trim().Split();
            int n = (int.Parse(array[0])) - 1;
            int m = int.Parse(array[1]);
            Console.WriteLine(text.Remove(n, m - n));

        }
    }
}
