using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("------------This program will give the sum total of 5 prices--------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            //Title
            int start = 1;
            int finish = 5;
            //Loop table

            Console.WriteLine($"please enter your price: "); 
            //question asked
            int Price = int.Parse(Console.ReadLine());
            //String the name price to read after the questions
            double total = 0;
            //Double acts like a float to add all the numbers pressed 
           

            for (int i = start; i <= finish; i++)
                //For is a looping statement - start you off to create the counter
                //int is the string for the char it represents - it sets out the number of times
                //i is the starting number
                //<= less than or equal too - stating it will keep loop if its less than or equal too otherwise it will break out of the cycle
                //i++ keeps looping variable 
            {
                Console.WriteLine($"Enter the price of this item:{Price*00.15} ");
                //Spits out the answer 
                total = Price + float.Parse(Console.ReadLine());
                //float adds all the numbers entered together 
                i++;
            }
            Console.Write($"The sum of the numbers you entered is: {total}");
            //total gives the final answer 
            Console.ReadLine();
            //reads the code in word format 
        }
    }
}
