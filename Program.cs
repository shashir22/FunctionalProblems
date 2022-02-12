using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program4
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double j = 0;
            for (double i = 1; i <= n; i++)
            {
                j = j + 1 / i;
                Console.WriteLine(j);

            }

        }
    }
}