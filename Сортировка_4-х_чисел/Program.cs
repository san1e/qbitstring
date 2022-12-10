using System;
using System.Linq;

namespace Сортировка_4х_чисел
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = String.Concat(str.OrderBy(ch=>ch));
            str = str.Remove(0, 3);
            string result = "";
            foreach (char c in str)
            {
                result += c + " ";
            }
            Console.WriteLine(result);

        }
    }
}
