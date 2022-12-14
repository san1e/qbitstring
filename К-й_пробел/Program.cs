using System;

namespace Кй_пробел
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int counter = 0;
            for (int i = 0; i < str.Length && counter != number; i++)
            {
                if (Char.IsWhiteSpace(str, i))
                {
                    counter++;
                    result = i;
                }
            }
            if (counter < number)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result + 1);
            }
        }
    }
}
