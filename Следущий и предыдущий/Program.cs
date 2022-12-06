using System;

namespace Следущий_и_предыдущий
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char A = Convert.ToChar(Console.ReadLine());
            int B = Convert.ToByte(A);
            int Anext = B + 1;
            char Anext1 = Convert.ToChar(Anext);
            int Aprev = B - 1;
            char Aprev1 = Convert.ToChar(Aprev);
            Console.WriteLine($"The next char for '{A}' ({B}) is '{Anext1}' ({Anext}).");
            Console.WriteLine($"The previous char for '{A}' ({B}) is '{Aprev1}' ({Aprev}).");
        }
    }
}
