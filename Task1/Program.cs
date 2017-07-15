using System;
using static System.Console;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Write("Input n: ");
            int n = Convert.ToInt32(ReadLine());
            long a = 1, b = 1, r = 0;
            for (int i = 0; i < n - 1; i++)
            {
                r = a + b;
                b = a;
                a = r;
            }
            long result = (long) Math.Pow(r, 2);
            WriteLine(r);
            WriteLine("result = {0}", result);
            Write("Press any key to continue . . . ");
            ReadKey(true);
        }
    }
}
