using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("----------This program can give the result of base^exponent----------------");
            Console.WriteLine("---------------------------------------------------------------------------"); //TITLE

            Console.WriteLine("Please Enter the value of the base: "); //Question
            double Base = float.Parse(Console.ReadLine()); //string 
            Console.Write("\nNow please enter the value of the exponent: \n"); //question 
            int exponent = int.Parse(Console.ReadLine()); //string

            Console.WriteLine($"Your result is {Base} ^ {exponent} = " + (Base + (exponent * exponent) + 5)); //answer 

            Console.WriteLine("please press enter to quit......"); //finishing statement
            Console.ReadLine(); //reads all code into word format       

        }
    }
}
