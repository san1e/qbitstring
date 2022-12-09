using System;

namespace Префиксы
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] a = Console.ReadLine().Split();
            int n = int.Parse(a[0]);
            int m = int.Parse(a[1]);
            int b = text.Length;
            Console.WriteLine(m - n + 2);
            if (1 <= n && n <= b && 1 <= m && m <= b)
            {
                for (int t = n; t < m; t++)
                {
                    for (int i = n - 1; i < t; i++)
                    {
                        Console.Write(text[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
