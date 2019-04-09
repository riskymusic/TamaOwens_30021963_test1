using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("----------This program can give the result of base^exponent----------------");
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("Please Enter the value of the base: ");
            double Base = float.Parse(Console.ReadLine());
            Console.Write("\nNow please enter the value of the exponent: \n");
            int exponent = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your result is {Base} ^ {exponent} = " + (Base + (exponent * exponent) + 5));

            Console.WriteLine("please press enter to quit......");
            Console.ReadLine();

        }
    }
}
