using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program3
    {
        public static void ToFindPower()
        {

            int b = 2;
            Console.WriteLine("Give the Exponent : ");
            int e = int.Parse(Console.ReadLine());
            if (0 <= e && e < 31)
            {
                Console.WriteLine("int e is overflow");
            }
            double Result = Math.Pow(b, e);
            Console.WriteLine("Result : {0}", Result);
            Console.ReadLine();

        }
    }
}