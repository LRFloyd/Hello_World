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

            string[] arg = { "LaVelle", " is", " a", " Developer" };
            for (int i = 0; i < arg.Length; i++)
            {
                Console.Write(arg[i],"\n");
            }

            ////Part one greeting statement
            string messageOne = "Hello World!";
            string messageTwo = "I'm a Developer";
            string messageThree = "LaVelle";
            string messageFour = " ";

            ////Part two set initial Developer attributes
            int ageOne = 34;
            int ageTwo = 45;
            int ageThree = 80;
            double heightOne = 72.50;
            double heightTwo = 91.45;
            float weightOne = 210.028461f;
            float weightTwo = 331.123457f;
            bool isHumanLikeOne = true;
            bool isHumanLikeTwo = false;
            char genderMale = 'M';
            char genderFemale = 'F';

            ////Part three displays variable values
            Console.WriteLine(messageOne);//displays intial greeting to console
            Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            Console.WriteLine(ageOne + ageTwo);//Addition example
            Console.WriteLine(heightOne - heightTwo);//Subtraction example
            Console.WriteLine(weightOne * weightTwo);//Multiplication example
            Console.WriteLine(isHumanLikeOne);//Bool example
            Console.WriteLine(genderMale);//Char example

         

        
    }
}
