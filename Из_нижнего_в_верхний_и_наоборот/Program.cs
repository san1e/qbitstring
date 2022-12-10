using System;

namespace Из_нижнего_в_верхний_и_наоборот
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char ch = Convert.ToChar(Console.ReadLine());
            int ch1 = Convert.ToInt32(ch);
            if (ch1 >= 65 && ch1 <= 90)
            {
                string str = Convert.ToString(ch);
                str = str.ToLower();
                Console.WriteLine(str);
            }
            else if (ch1 >= 97 && ch1 <= 122)
            {
                string str = Convert.ToString(ch);
                str = str.ToUpper();
                Console.WriteLine(str);
            }
        }
    }
}
