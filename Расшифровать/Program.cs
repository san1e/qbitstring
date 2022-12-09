using System;

namespace Расшифровать
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine()); ;
            string str = "";
            string[] data = Console.ReadLine().Trim().Split();
            for (int i = 0; i < num; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(data[i])).ToString();
                
            }
            Console.WriteLine(str);
        }
    }
}
