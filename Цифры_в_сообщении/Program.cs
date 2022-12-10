using System;

namespace Цифры_в_сообщении
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int count = 0;
            int sum = 0;
            foreach (char c in str)
            {

                if (Char.IsDigit(c))
                {
                    count++;
                }
                if (int.TryParse(c.ToString(), out int num1))
                {
                    sum += num;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
