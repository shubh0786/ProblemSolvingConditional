using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
namespace ifPro5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Please write your age");
            int age = int.Parse(Console.ReadLine());



            
        

            if (age >= 18)
            {

                Console.WriteLine("Your elgible to cast your vote");

            }

            else
            {
                Console.WriteLine("you are not eligible comeback after {0}",18-age);
            }
          Console.ReadLine();

        }
    }
}
