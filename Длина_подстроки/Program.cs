using System;

namespace Длина_подстроки
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] data = Console.ReadLine().Trim().Split();
            int x = Convert.ToInt32(data[0])-1;
            int y = Convert.ToInt32(data[1]);
            if (x > y)
            {
                Console.WriteLine(0);
            }
            else
            {
                string UnderStr = str.Substring(x,y-x);
                int StrUnderLength = UnderStr.Length;
                Console.WriteLine(StrUnderLength);
                Console.WriteLine(UnderStr);
            }
        }
    }
}
