using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{

    class Program

    {
        public static char tryAgain;

        static void Main(string[] args)
        {

            void guesstheNumber()
            {

                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(1, 11);

                int userGuess, amountGuess = 0, scoreGuess = 100;

                do
                {
                    Console.WriteLine("Guess the random number (1 - 10)");
                    userGuess = int.Parse(Console.ReadLine());
                    if (userGuess < randomNumber)
                    {
                        Console.WriteLine("Your guess was to low");
                    }
                    else if (userGuess > randomNumber)
                    {
                        Console.WriteLine("Your guess was too high");
                    }
                    else if (userGuess == randomNumber)
                    {
                        Console.WriteLine("Your guess is correct");
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number.");
                    }
                    amountGuess++;

                } while (userGuess != randomNumber);

                Console.WriteLine("You guessed {0} times", amountGuess);

                if (amountGuess == 1)
                {
                    Console.WriteLine("You scored {0}! you guess it on {1} try.", scoreGuess, amountGuess);
                }
                else if (amountGuess > 1 || amountGuess <= 3)
                {
                    Console.WriteLine("You scored {0}!", scoreGuess - 10);
                }
                else if (amountGuess >= 4 || amountGuess <= 6)
                {
                    Console.WriteLine("You scored {0}!", scoreGuess - 20);
                }
                else if (amountGuess >= 7 || amountGuess <= 10)
                {
                    Console.WriteLine("You scored {0}!, try to improve next time", scoreGuess - 30);
                }
                else
                {
                    Console.WriteLine("You guessed {0} times, try again next time.", amountGuess);
                }

                Console.Write("Try Again (y/n)?");
                tryAgain = char.Parse(Console.ReadLine());
                
            }

            guesstheNumber();

            if (tryAgain == 'y' || tryAgain == 'Y')
            {
                Console.WriteLine();
                guesstheNumber();
            } else if (tryAgain == 'n' || tryAgain == 'N')
            {
                Console.WriteLine("Nice Game!");
            }


            Console.ReadKey();
        }
        
    }

}
