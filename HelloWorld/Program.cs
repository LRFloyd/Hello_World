using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              * LaVelle R Floyd
              * First Application Hello World
              * In this application I learned from Instructors the basics of programming in C# to more advanced teachings.
              * 
              * the following are things I learned:
              * Variables 
              * If statements 
              * Switch Statements
              * Arrays 
              * Loops
              * Methods
             */

            //INTRO
            
            Console.WriteLine("Hello World");

            string[] arg = {"LaVelle", " is", " a", " Developer"};
            for (int i = 0; i < arg.Length; i++)
            {
                Console.Write(arg[i], "\n");
            }

        }


    }
}
