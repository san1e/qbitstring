using System;
using System.Text;
namespace Образец_текст
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           string P =Console.ReadLine();
            string T = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int count = 0;
           while (i < P.Length)
            {
                count++;
                if (P[i] == T[k-1])
                {
                    i++;
                    k++;
                   
                }
                else
                {
                    
                    k++;
                    break;
                }
            }
            if (T.Contains(P))
            {
                global::System.Console.WriteLine("YES");
                global::System.Console.WriteLine(count);
            }
            else
            {
                global::System.Console.WriteLine("NO");
                global::System.Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
