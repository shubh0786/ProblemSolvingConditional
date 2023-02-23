using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to accept two integers and check whether they are equal or not.

namespace if_Pro1
{
  public class Program
    {

      
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Please enter first number");

            a = int.Parse(Console.ReadLine());


            Console.WriteLine("Please enter second number");

            b = int.Parse(Console.ReadLine());

            if (a==b)
            {

                Console.WriteLine("Both numbers are equal: {0} {1}", a,b);
            }
            else
            {

                Console.WriteLine("Numers are not equal: first numeber{0} second number{1}", a,b);
            }
            Console.ReadLine();
        }
    }
}
