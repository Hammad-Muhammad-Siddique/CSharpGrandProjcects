using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Project_3___String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // The string of the user
            string word;

            // The operation the user wants to apply
            string opWord;

            // temporary string
            string inWord;


            // introduce the program to the user and ask for a string
            Console.WriteLine("Hello and welcome to the String Manipulator Program!");
            Console.WriteLine();
            Console.WriteLine("Input a string and this program will display a set of ways of how you can manipulate your string");
            Console.WriteLine();
            Console.Write("Enter the string: ");
            word = Console.ReadLine();


            // display the string manipulation menu
            Console.WriteLine("Now please select the operation that you want to perform on your string");
            Console.WriteLine();
            Console.WriteLine("To convert your string to uppercase, enter uppercase");
            Console.WriteLine();
            Console.WriteLine("To convert your string to lowercase, enter lowercase");
            Console.WriteLine();
            Console.WriteLine("To search your string for a letter or word, enter the letter word");
            Console.WriteLine();
            Console.WriteLine("To find the index number of a letter or word in your string, enter that letter/word");
            Console.WriteLine();
            inWord = Console.ReadLine();
            Console.WriteLine();
            


            // apply operations and display answer
                if (inWord == "uppercase")
                {
                    opWord = word.ToUpper();
                    Console.WriteLine("Your string " + word + " in uppercase is " + opWord);
                }
                else if (inWord == "lowercase")
                {
                    opWord = word.ToLower();
                    Console.WriteLine("Your string " + word + " in lowercase is " + opWord);
                }
                else if (inWord.Length == 1)
                {
                    if (word.Contains(inWord) == false)
                    {
                    Console.WriteLine("Your string doesn't contain that letter");
                    }
                    else if (word.Contains(inWord) == true)
                    {
                        Console.WriteLine("Your string contains that letter");
                    }

                }
                else
            {
                    if (word.Contains(inWord) == false)
                    {
                        Console.WriteLine("Your string doesn't contain that word");
                    }
                    else if (word.Contains(inWord) == true)
                    {
                        Console.WriteLine("Your string contains that word");
                    }
            }
          
            Console.ReadKey();
        }
    }
}
