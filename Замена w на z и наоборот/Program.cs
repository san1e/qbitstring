using System;
using System.Text;

namespace Замена_w_на_z_и_наоборот
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(text);
            foreach (byte e in asciiBytes)
            {
                if (e == 122)
                {
                    Console.Write("{0}", (char)119);
                }
                else if (e == 119)
                {
                    Console.Write("{0}", (char)122);
                }
                else
                {
                    Console.Write("{0}", (char)e);
                }
            }
        }
    }
}
