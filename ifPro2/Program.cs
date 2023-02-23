using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a C# Sharp program to check whether a given number is even or odd
namespace ifPro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add your numer");

            int a = int.Parse(Console.ReadLine());

            int b = a % 2;


            if (b==0)
            {
                Console.WriteLine("Number is even {0}", a);


            }
            else
            {

                Console.WriteLine("Numer is odd {0}", a);
            }

            Console.ReadLine();
        }
    }
}
