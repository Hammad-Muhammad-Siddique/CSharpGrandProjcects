using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grand_Project_4___Word_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "hammad";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            Console.WriteLine("                    Welcome to the Word Guessing Game!");
            Console.WriteLine();
            Console.WriteLine("A random word has been generated and you have 3 attempts to guess it.");
            Console.WriteLine();
   
            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("Oops! You reached the guess limit. Please try again!");
            }
            else
            {
                Console.WriteLine("Great! You guessed it!");
            }

            Console.ReadKey();
        }

    }
}
