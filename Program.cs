
using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program5
    {
        public static void Factors()
        {
            Console.WriteLine("Please enter your integer: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}