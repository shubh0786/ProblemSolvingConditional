using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to find whether a given year is a leap year or not.

namespace ifPro4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter the year");
            int year = int.Parse(Console.ReadLine());


            if (year % 400 == 0)


                Console.Write("Year is a leap year: {0}", year);

            else if (year % 100 == 0)
                Console.Write("Year is a leap year: {0}", year);

            else if (year % 4 == 0)
                Console.Write("Year is a leap year: {0}", year);

            else Console.Write("Yeare is not a leap year: {0}", year);


            Console.ReadLine();

        }

        
        }
    }
