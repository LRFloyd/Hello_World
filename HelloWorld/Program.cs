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
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.028461f;
            //float weightTwo = 331.123457f;
            bool isHumanLikeOne = true;
            //bool isHumanLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';

            ////Part three displays variable values
            //Console.WriteLine(messageOne);//displays intial greeting to console
            //Console.WriteLine(messageTwo);

            ////Part four mathematical operator, bool and char examples
            //Console.WriteLine(ageOne + ageTwo);//Addition example
            //Console.WriteLine(heightOne - heightTwo);//Subtraction example
            //Console.WriteLine(weightOne * weightTwo);//Multiplication example
            //Console.WriteLine(isHumanLikeOne);//Bool example
            //Console.WriteLine(genderMale);//Char example

            ////Part five variable reassignment
            //ageTwo = 70;
            //heightTwo = 35.12345f;
            //weightTwo = -429.1234573f;

            ////Part six mathematical operator examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree % ageOne);
            //Console.WriteLine(ageThree / ageOne);

            ////Part seven increment and decrement operator examples
            //ageTwo = ageTwo + 1;
            //Console.WriteLine(ageTwo);
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);
            //ageTwo--;

            //Part eight concatenation example
            //Console.WriteLine(messageOne + " " + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old, and it is true that " + messageTwo + ".");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            //Console.WriteLine("My father is {0} years old, and it is {1} that he is a human.", ageThree, isHumanLikeOne);
            //Console.WriteLine("I am {0} years old, and it is true that {1}.", ageOne, messageTwo);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall.", weightOne, heightOne);

            ////Part nine string equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I'm a Developer"));

            //Part ten string length examples
            //int messOneLength = messageOne.Length;
            //int messTwoLength = messageTwo.Length;

            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messOneLength);
            //Console.WriteLine("The length of messageTwo is " + messTwoLength);

            //Part 11: Conditionals examples
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            //Solicit user input
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if ((city1Distance <= 125) &&((city1Distance < city2Distance) && (city1Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to {0}", city1);
            //}
            //if ((city2Distance <= 125)&&((city2Distance < city1Distance)&&(city2Distance < city3Distance)))
            //{
            //    Console.WriteLine("We will march to " + city2);
            //}
            //if ((city3Distance <= 125)&&((city3Distance < city2Distance)&&(city3Distance < city1Distance)))
            //{
            //    Console.WriteLine("We will march to {0}", city3);
            //}

            //Console.WriteLine("What is your rank soldier?");
            //string rank = Console.ReadLine().ToLower();

            //Console.WriteLine("What is your age soldier");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is your job soldier");
            //string job = Console.ReadLine().ToLower();

            //if ((rank == "officer")||(age <=26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else if ((job == "cook")&&(age >= 26))
            //{
            //    Console.WriteLine("My army has to eat. Pack you pots and pans.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, your staying home.");
            //}

            //switch (job)
            //{
            //    case "infantry":
            //        Console.WriteLine("You will carry a sword.");
            //        break;

            //    case "archer":
            //        Console.WriteLine("You will carry a bow and arrow.");
            //        break;

            //    case "supply":
            //        Console.WriteLine("You will carry pots and pans.");
            //        break;

            //    case "specialist":
            //        Console.WriteLine("You will operate the catapult.");
            //        break;

            //    default:
            //        Console.WriteLine("You will ride horseback.");
            //        break;

            //Part 12 array examples
            //string[] foodList = new string[6];
            //foodList[0] = "Milk";
            //foodList[1] = "Fruit";
            //foodList[2] = "Meat";
            //foodList[3] = "Wine";
            //foodList[4] = "Bread";
            //foodList[5] = "Water";
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", foodList[0], foodList[1], foodList[2], foodList[3], foodList[4]);

            int[] foodAmount = new int[] { 1000, 1000, 2000, 10000, 15000 };
            //Console.WriteLine(foodAmount[0] + ", " + foodAmount[1] + ", " + foodAmount[2] + ", " + foodAmount[3] + ", " + foodAmount[4]);

            //string[] elements = messageTwo.Split(' ');
            //Console.Write(elements[0]);
            //Console.Write(elements[1]);
            //Console.WriteLine(elements[2]);
            //Console.WriteLine(elements.Length);

            //string myName = "Vell";
            //char[] letters = myName.ToCharArray();
            //Console.WriteLine("{0}"+"{1}"+"{2}"+"{3}", letters[0], letters[1], letters[2], letters[3]);
            //Console.Write(letters[0]);
            //Console.Write(letters[1]);
            //Console.Write(letters[2]);
            //Console.WriteLine(letters[3]);

            //}

            isHumanLikeOne = IsHumanLike(ageOne);
            Console.WriteLine("To say our male is Human like is " + isHumanLikeOne);
            /* 1) the bool variable 'isHumanLikeOne' is assigned the return value of 'IsHumanLike' method call
             * 2) the value of the int variable 'ageOne' is passed to the method call 'IsHumanLike'.
             * 3) when the complier executes the new assigned bool 'isHumanLikeOne' it executes the 'IsHumanLike' method call 
             * 4) the complier exits the main method and executes 'IsHumanLike' method
             * 5) the value of the int variable 'ageOne' is passed to 'IsHumanLike' method parameter 'age'
             * 6) the value of 'age' is passed to the conditional statement
             * 7) after being processed the return value 'status' is passed back to 'IsHumanLike' 
             * and the value of the method call is assigned to the variable 'isHumanLikeOne'
             * which the Console.WriteLine() method prints the value of it.
             * 
             * 
             */

            Console.WriteLine(Reverse(messageTwo));
            /* 
             * 1) the complier executes the 'Console.WriteLine()' method call leaveing the main method and executes the 'Reverse' method call
             * 2) 
            */

            Console.WriteLine("The total sum of the foodAmount array is {0}", SumArray(foodAmount));
        }
        static int SumArray(int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }

        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = " ";
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        static bool IsHumanLike(int age)
        {
            bool status;
            if (age % 2 == 0)
            {
                status = false;
            }
            else
            {
                status = true;
            }
            return status;
        }

        
    }
}
