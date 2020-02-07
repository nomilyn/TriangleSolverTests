using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040A2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string TriangleSelection;
            string TriangleAnalyze;
            while (true)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("1 = Enter the Triangle's Dimensions\n");
                Console.WriteLine("2 = Exit\n");
                Console.WriteLine("******************************************");
                Console.WriteLine("Please choose a menu item to begin:");
                TriangleSelection = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("******************************************");

                if (TriangleSelection != "1" && TriangleSelection != "2")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (int.Parse(TriangleSelection) == 1)
                {

                    int firstDimension;
                    int secondDimension;
                    int thirdDimension;

                    firstDimension = ValidateUserInput("First Side");
                    secondDimension = ValidateUserInput("Second Side");
                    thirdDimension = ValidateUserInput("Third Side");

                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("You provided that the three dimensions of Triangle are {0} ,{1} and {2}.\n",
                        firstDimension, secondDimension, thirdDimension);
                    TriangleAnalyze = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);
                    Console.WriteLine(TriangleAnalyze);


                }
                else if (int.Parse(TriangleSelection) == 2)
                {
                    System.Environment.Exit(0);

                }
            }
        }

        public static int ValidateUserInput(string chosenNumber)
        {
            int aNumber = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Please enter the {0}:", chosenNumber);
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = (int.TryParse(userInput, out aNumber) && aNumber > 0);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input please, please try again.\n");
                }

                else
                {
                    isValid = true;
                    Console.WriteLine("Your {0} has been chosen to: {1}.\n", chosenNumber, aNumber);
                }
            }

            return aNumber;
        }
    }
}
