using System;
using System.Collections.Generic;
using System.Text;

namespace program2
{
    class Program1
    {
        public static void LeapYear()
        {

            String b = "2021";
            if (b.Length != 4)
            {

                Console.WriteLine(b + " is not a 4 digit number");
                b = Console.ReadLine();


            }
            int Year = Int32.Parse(b);

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("Leap Year" + Year);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("not a Leap Year" + Year);
                Console.ReadLine();
            }



        }
    }
}