using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Can you solve the following algebraic expression: ");
            Console.WriteLine("---------------2(x - 3) + x = 12 -----------------");//Title 
            Console.WriteLine("--------------------------------------------------");
            int number = 2; //Int equals to the answer 

            Console.WriteLine("Enter your guess at the value of x: "); //ask questions 
            int guess = int.Parse(Console.ReadLine()); //int related to there answer and passes it through to readline
            if (guess == number) //If statement is true to the guess equal to the number it will read line below
                Console.WriteLine("You got it, good work!");
            
            else if (guess > number); //if answer is wrong it will readline below
            
            
                Console.WriteLine("Sorry your guess is lower than the answer, Please try again");
            Console.WriteLine("Here's the answer:\n 2(x-3) + x = 12 \n 2x-6+2x=12\n 4x-6=12 \n (4+2) (3+3)\n x=2"); //answer to workings
            
            Console.ReadLine(); //read the code in word format 
            Console.Clear(); //clears code after pushing enter for the second time 
        }
    }
}
