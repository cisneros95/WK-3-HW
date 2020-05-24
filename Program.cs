using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IF_STATEMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            double num01;
            double num02;

            Console.Write("Enter a number to be divided: ");
            num01 = Convert.ToInt32 (Console.ReadLine () );
            Console.Write("Enter a number to divide by: ");
            num02 = Convert.ToInt32(Console.ReadLine () );


            Console.WriteLine( num01 + " divided by " + num02 + " is equal to  " + num01 / num02);


            // Wait for the user to press a key. Then make empty space and start over.

            Console.ReadKey();
            Console.WriteLine();
            goto Start; // Jumps to "Start:".












            /////////////////////////////////////////////////////////////////////
            //Console.WriteLine("How old are you?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age < 18)
            //{
            //    Console.WriteLine("That's too bad! You will have to wait a couple of years.");
            //}
            //else if (age == 18)
            //{
            //    Console.WriteLine("Puh, barely made it!");
            //}
            //else
            //{
            //    Console.WriteLine("You are allowed to enter.");
            //}
            //Console.ReadKey();
            //{  
            //}

        }
    }
}
