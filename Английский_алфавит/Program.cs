using System;

namespace Английский_алфавит
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char char1 = Convert.ToChar(Console.ReadLine());
            char char2 = Convert.ToChar(Console.ReadLine());
            int ch1 = Convert.ToInt32(char1);
            int ch2 = Convert.ToInt32(char2);
            string str = "";
            if (ch1 < ch2 || ch1 == ch2)
            {
                for (int i = ch1; i <= ch2; i++)
                {
                    char c = Convert.ToChar(i);
                    string sc = Convert.ToString(c);
                    string scup = sc.ToUpper();

                    str +=$"{scup+sc} ";
                }
                Console.WriteLine(str);
            }
            else if (ch1 > ch2 || ch1 == ch2)
            {
                for (int i = ch2; i <= ch1; i++)
                {
                    char c = Convert.ToChar(i);
                    string sc = Convert.ToString(c);
                    string scup = sc.ToUpper();

                    str += $"{scup + sc} ";
                }
                Console.WriteLine(str);
            }
        }
    }
}
