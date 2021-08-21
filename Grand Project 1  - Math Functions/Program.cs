using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Project_1____Math_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueNumber;
            double number1;
            string operation1;
            double mathFunction;
            double number2;
            double number3;
            
            Console.WriteLine("Hello and thankyou for using this program! This program is about math functions.");
            Console.WriteLine();
            Console.Write("You can apply math functions on either one value or two values. Please enter you choice as a number: ");
            valueNumber = Convert.ToInt32(Console.ReadLine());

            if (valueNumber == 1)
            {
                Console.Write("Great choice! Enter your number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("To square your value, enter square");
                Console.WriteLine("To take your value's squareroot, enter squareroot");
                Console.WriteLine("To round your value, enter round");
                Console.WriteLine("To remove any decimal values, enter trancate");
                Console.WriteLine("To find the absolute value of your number, enter absolute");
                Console.WriteLine();
                Console.Write("Enter the operation: ");
                operation1 = Console.ReadLine();

                if (operation1 == "square")
                {
                    mathFunction = number1 * number1;
                    Console.WriteLine("The square of " + number1 + " is " + mathFunction);
                }
                else if (operation1 == "squareroot")
                {
                    mathFunction = Math.Sqrt(number1);
                    Console.WriteLine("The square root of " + number1 + " is " + mathFunction);
                }
                else if (operation1 == "round")
                {
                    mathFunction = Math.Round(number1);
                    Console.WriteLine("The round value of" + number1 + " is " + mathFunction);
                }
                else if (operation1 == "trancate")
                {
                    mathFunction = Math.Truncate(number1);
                    Console.WriteLine("The number " + number1 + " without the decimals is " + mathFunction);
                }
                else if (operation1 == "absolute")
                {
                    mathFunction = Math.Abs(number1);
                    Console.WriteLine("The absolute value of " + number1 + " is " + mathFunction);
                }
                else
                {
                    Console.WriteLine("You have entered an invalid operator, please restart the program");
                }


            }
            else if (valueNumber == 2)
            {
                Console.Write("Enter first number: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                number3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("To find the greater of the two values, enter maximum");
                Console.WriteLine("To find the smaller of the two values, enter minimum");
                Console.WriteLine("To find one value as a power of the other, enter power");
                operation1 = Console.ReadLine();

                if (operation1 == "maximum")
                {
                    mathFunction = Math.Max(number3, number2);
                    Console.WriteLine("The greater among" + number2 + " & " + number3 + " is " + mathFunction);
                }
                else if (operation1 == "minimum")
                {
                    mathFunction = Math.Min(number3, number2);
                    Console.WriteLine("The smaller among" + number2 + " & " + number3 + " is " + mathFunction);
                }
                else if (operation1 == "power")
                {
                    mathFunction = Math.Pow(number2, number3);
                    Console.WriteLine(number2 + " to the power " + number3 + " is " + mathFunction);

                }
                else
                {
                    Console.WriteLine("You have entered an invalid operator, please restart the program");
                }

            }
            else
            {
                Console.WriteLine("Invalid value, please restart the program");
            }

            Console.ReadKey();
        }
    }
}