using System;

namespace Удаление_символов
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] array = Console.ReadLine().Trim().Split();
            int x = Convert.ToInt32(array[0])-1;
            int y = Convert.ToInt32(array[1]);
            Console.WriteLine(str.Remove(x, y - x));
            Console.ReadKey();

        }
    }
}
