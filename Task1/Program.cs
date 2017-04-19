using System;

namespace Task1
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long a = 1, b = 1, r = 0;
            for (int i = 0; i < n - 1; i++)
            {
                r = a + b;
                b = a;
                a = r;
            }
            long result = (long) Math.Pow(r, 2);
            Console.WriteLine(r);
            Console.WriteLine("result = {0}", result);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }
    }
}
