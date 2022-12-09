using System;

namespace Зашифровать
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            string str1 = "";
            foreach (char c in str)
            {
                int a = Convert.ToInt32(c);
                str1 += Convert.ToString($"{a} ");
            }
            Console.Write(str1);
        }
    }
}
