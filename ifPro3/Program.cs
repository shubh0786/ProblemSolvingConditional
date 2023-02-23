using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write a C# Sharp program to check whether a given number is positive or negative.
namespace ifPro3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please add your numer");

            int a = int.Parse(Console.ReadLine());

            if (a>=0)
            {

                Console.WriteLine("Number is positive {0}", a);

            }
            else
            {

                Console.WriteLine("Number is negative {0}", a);

            }

            Console.ReadLine();
        }


    }
}
