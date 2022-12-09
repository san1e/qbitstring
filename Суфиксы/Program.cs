using System;

namespace Суфиксы
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
            int c = m - n, k = 0;
            if (1 <= n && n <= b && 1 <= m && m <= b)
            {
                Console.WriteLine(m - n + 2);
            }
            if (1 <= n && n <= b && 1 <= m && m <= b)
            {
                for (int t = m; k < c;)
                {
                    for (int i = n; i < t; i++)
                    {
                        Console.Write(text[i]);
                    }
                    k++;
                    Console.WriteLine();
                    n++;
                }
            }
        }
    }
}
